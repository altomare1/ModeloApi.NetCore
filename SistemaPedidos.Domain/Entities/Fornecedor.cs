using System;
using System.Collections.Generic;

namespace SistemaPedidos.Domain.Entities
{
    public class Fornecedor
    {
        public int FornecedorID { get; set; }
        public string Codigo { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }
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
        public string Contato { get; set; }
        public string Email { get; set; }
        public string Observacao { get; set; }
        public bool Status { get; set; }
        public string UsuarioInclusao { get; set; }
        public DateTime DataInclusao { get; set; }
        public string UsuarioAltracao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public virtual ICollection<Movimento> Despesas { get; set; }
    }
}
