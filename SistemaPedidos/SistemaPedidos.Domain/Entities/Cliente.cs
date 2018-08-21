using System;
using System.Collections.Generic;

namespace SistemaPedidos.Domain.Entities
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Codigo { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string CpfCnpj { get; set; }
        public string RgInscricaoEstadual { get; set; }
        public DateTime DataNascimento { get; set; }
        public string TipoPessoa { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string TelefoneComercial { get; set; }
        public string Celular { get; set; }
        public string EnderecoCobranca { get; set; }
        public string NumeroCobranca { get; set; }
        public string ComplementoCobranca { get; set; }
        public string BairroCobranca { get; set; }
        public string CidadeCobranca { get; set; }
        public string EstadoCobranca { get; set; }
        public string CepCobranca { get; set; }
        public string TelefoneCobranca { get; set; }
        public string Contato { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public string Observacao { get; set; }
        public bool Status { get; set; }
        public bool IndicadorComissao { get; set; }
        public decimal PercentualComissao { get; set; }
        public int FuncionarioID { get; set; }
        public string UsuarioInclusao { get; set; }
        public DateTime DataInclusao { get; set; }
        public string UsuarioAltracao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public virtual ICollection<Movimento> Receitas { get; set; }

        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Status && DateTime.Now.Year - cliente.DataInclusao.Year >= 5;
        }
    }
}
