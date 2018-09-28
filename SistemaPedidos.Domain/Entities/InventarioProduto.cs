using System;

namespace SistemaPedidos.Domain.Entities
{
    public class InventarioProduto
    {
        public int InventarioProdutoID { get; set; }
        public int ProdutoID { get; set; }
        public DateTime DataInventario { get; set; }
        public int EstoqueSistema { get; set; }
        public int EstoqueContabil { get; set; }
        public decimal SaldoContabil { get; set; }
        public string Observacoes { get; set; }
        public bool Status { get; set; }
        public string UsuarioInclusao { get; set; }
        public DateTime DataInclusao { get; set; }
        public string UsuarioAltracao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string NomeProduto { get; set; }
        public int QuantidadeEstoque { get; set; }

        public decimal CalcularSaldoContabil(decimal precoCusto)
        {
            var quantidadeEstoque = CalcularDiferencaEstoque();
            return quantidadeEstoque * precoCusto;
        }

        public int CalcularDiferencaEstoque()
        {
            return EstoqueSistema - EstoqueContabil;
        }
    }
}
