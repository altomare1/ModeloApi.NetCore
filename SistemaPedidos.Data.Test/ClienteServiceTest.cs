using Moq;
using SistemaPedidos.Data.Services;
using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Repositories;
using SistemaPedidos.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xunit;

namespace SistemaPedidos.Data.Test
{
    public class ClienteServiceTest
    {
        private ICollection<Cliente> _clientes;
        private IClienteService _appService;
        private Mock<IClienteRepository> clienteRepositoryMock = new Mock<IClienteRepository>();

        public ClienteServiceTest()
        {
            _clientes = PreencherClientesMock();
            _appService = new ClienteService(clienteRepositoryMock.Object);
        }

        [Fact]
        public void ObterClientesEspeciaisServiceTest()
        {
            clienteRepositoryMock.Setup(x => x.GetAll()).Returns(_clientes);
            Assert.NotEmpty(_appService.ObterClientesEspeciais());
        }

        private ICollection<Cliente> PreencherClientesMock()
        {
            return new Collection<Cliente>()
            {
                new Cliente()
                {
                    ClienteID = 1,
                    Codigo = "ABC",
                    RazaoSocial = String.Empty,
                    NomeFantasia = String.Empty,
                    CpfCnpj = String.Empty,
                    RgInscricaoEstadual = String.Empty,
                    DataNascimento = DateTime.Now.AddYears(-30),
                    TipoPessoa = String.Empty,
                    Endereco = String.Empty,
                    Numero = String.Empty,
                    Complemento = String.Empty,
                    Bairro = String.Empty,
                    Cidade = String.Empty,
                    Estado = String.Empty,
                    Cep = String.Empty,
                    Telefone = String.Empty,
                    TelefoneComercial = String.Empty,
                    Celular = String.Empty,
                    EnderecoCobranca = String.Empty,
                    NumeroCobranca = String.Empty,
                    ComplementoCobranca = String.Empty,
                    BairroCobranca = String.Empty,
                    CidadeCobranca = String.Empty,
                    EstadoCobranca = String.Empty,
                    CepCobranca = String.Empty,
                    TelefoneCobranca = String.Empty,
                    Contato = String.Empty,
                    Email = String.Empty,
                    Sexo = String.Empty,
                    Observacao = String.Empty,
                    Status = true,
                    IndicadorComissao = true,
                    PercentualComissao = 10,
                    FuncionarioID = 1,
                    UsuarioInclusao = String.Empty,
                    DataInclusao = DateTime.Now,
                    UsuarioAltracao = String.Empty,
                    DataAlteracao = DateTime.Now,
                    Funcionario = null,
                    Receitas = null
                },
                new Cliente()
                {
                    ClienteID = 1,
                    Codigo = "ABC",
                    RazaoSocial = String.Empty,
                    NomeFantasia = String.Empty,
                    CpfCnpj = String.Empty,
                    RgInscricaoEstadual = String.Empty,
                    DataNascimento = DateTime.Now.AddYears(-30),
                    TipoPessoa = String.Empty,
                    Endereco = String.Empty,
                    Numero = String.Empty,
                    Complemento = String.Empty,
                    Bairro = String.Empty,
                    Cidade = String.Empty,
                    Estado = String.Empty,
                    Cep = String.Empty,
                    Telefone = String.Empty,
                    TelefoneComercial = String.Empty,
                    Celular = String.Empty,
                    EnderecoCobranca = String.Empty,
                    NumeroCobranca = String.Empty,
                    ComplementoCobranca = String.Empty,
                    BairroCobranca = String.Empty,
                    CidadeCobranca = String.Empty,
                    EstadoCobranca = String.Empty,
                    CepCobranca = String.Empty,
                    TelefoneCobranca = String.Empty,
                    Contato = String.Empty,
                    Email = String.Empty,
                    Sexo = String.Empty,
                    Observacao = String.Empty,
                    Status = true,
                    IndicadorComissao = true,
                    PercentualComissao = 10,
                    FuncionarioID = 1,
                    UsuarioInclusao = String.Empty,
                    DataInclusao = DateTime.Now.AddYears(-7),
                    UsuarioAltracao = String.Empty,
                    DataAlteracao = DateTime.Now,
                    Funcionario = null,
                    Receitas = null
                }
            };
        }
    }
}
