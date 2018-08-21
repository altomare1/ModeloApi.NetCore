using System;
using System.Collections.Generic;

namespace SistemaPedidos.Domain.Entities
{
    public class Pedido
    {
        public int PedidoID { get; set; }
        public string NumeroPedido { get; set; }
        public int QuantidadeItens { get; set; }
        public DateTime DataPedido { get; set; }
        public DateTime DataEntrada { get; set; }
        public decimal TotalNota { get; set; }
        public bool Status { get; set; }
        public string UsuarioInclusao { get; set; }
        public DateTime DataInclusao { get; set; }
        public string UsuarioAltracao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public virtual ICollection<PedidoItem> PedidoItem { get; set; }
    }
}
