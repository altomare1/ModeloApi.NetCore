using System;

namespace SistemaPedidos.Domain.Entities
{
    public class PedidoItem
    {
        public int PedidoItemID { get; set; }
        public int NumeroItem { get; set; }
        public int UnidadeCompra { get; set; }
        public int QuantidadeCompra { get; set; }
        public decimal TotalItem { get; set; }
        public bool Status { get; set; }
        public int PedidoID { get; set; }
        public int ProdutoID { get; set; }
        public DateTime DataInclusao { get; set; }
    }
}