using System;

namespace SistemaPedidos.Domain.Entities
{
    public class ComissaoFuncionario
    {
        public int ComissaoFuncionarioID { get; set; }
        public decimal ValorComissao { get; set; }
        public string UsuarioInclusao { get; set; }
        public DateTime DataInclusao { get; set; }
        public string UsuarioAltracao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public int MovimentoID { get; set; }
        public virtual Movimento Movimento { get; set; }
    }
}
