using Newtonsoft.Json;
using SistemaPedidos.Application.Interface;
using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Services;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;

namespace SistemaPedidos.Application
{
    public class FuncionarioAppService : AppServiceBase<Funcionario>, IFuncionarioAppService
    {
        private readonly IFuncionarioService _appService;

        public FuncionarioAppService(IFuncionarioService appService) 
            : base(appService)
        {
            _appService = appService;
        }

        public Funcionario RetornaDadosFuncionario()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string ts = DateTime.Now.Ticks.ToString();
                string publicKey = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                string hash = GerarHash(ts, publicKey, "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");

                HttpResponseMessage response = client.GetAsync(
                    "http://gateway.marvel.com/v1/public/" +
                    $"characters?ts={ts}&apikey={publicKey}&hash={hash}&" +
                    $"name={Uri.EscapeUriString("Captain America")}").Result;

                response.EnsureSuccessStatusCode();
                string conteudo =
                    response.Content.ReadAsStringAsync().Result;

                dynamic resultado = JsonConvert.DeserializeObject(conteudo);

                Funcionario funcionario = new Funcionario
                {
                    Nome = resultado.data.results[0].name,
                    Observacao = resultado.data.results[0].description
                };

                return funcionario;
            }
        }

        private string GerarHash(string ts, string publicKey, string privateKey)
        {
            byte[] bytes =
                Encoding.UTF8.GetBytes(ts + privateKey + publicKey);
            var gerador = MD5.Create();
            byte[] bytesHash = gerador.ComputeHash(bytes);
            return BitConverter.ToString(bytesHash)
                .ToLower().Replace("-", String.Empty);
        }
    }
}