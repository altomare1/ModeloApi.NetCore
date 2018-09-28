using System;
using System.Collections.Generic;

namespace SistemaPedidos.Domain.Entities
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public string Codigo { get; set; }
        public string CodigoInterno { get; set; }
        public string Descricao { get; set; }
        public string UnidadeVenda { get; set; }
        public decimal PrecoCusto { get; set; }
        public decimal PrecoVenda { get; set; }
        public int QuantidadeEstoque { get; set; }
        public bool Status { get; set; }
        public int SecaoProdutoID { get; set; }
        public string UsuarioInclusao { get; set; }
        public DateTime DataInclusao { get; set; }
        public string UsuarioAltracao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public virtual SecaoProduto SecaoProduto { get; set; }
        public virtual ICollection<PedidoItem> PedidoItem { get; set; }

        public void AtualizarEstoqueProduto(int quantidadeAtualizar)
        {
            if (quantidadeAtualizar < 0)
                QuantidadeEstoque = QuantidadeEstoque - (quantidadeAtualizar*(-1));
            else
                QuantidadeEstoque = QuantidadeEstoque + quantidadeAtualizar;
        }
    }
}
