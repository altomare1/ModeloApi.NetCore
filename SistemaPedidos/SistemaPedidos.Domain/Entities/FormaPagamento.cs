using System;

namespace SistemaPedidos.Domain.Entities
{
    public class FormaPagamento
    {        
        public int FormaPagamentoID { get;  set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int DiasPrazo { get; set; }
        public double Taxa { get; set; }
        public bool DiasUteis { get; set; }
        public string UsuarioInclusao { get; set; }
        public DateTime DataInclusao { get; set; }
        public string UsuarioAltracao { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}
