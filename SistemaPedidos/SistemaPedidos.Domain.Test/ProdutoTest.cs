using System;
using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Utils.Enums;
using Xunit;

namespace SistemaPedidos.Domain.Test
{
    public class ProdutoTest
    {
        private Produto _produto;

        public ProdutoTest()
        {
            _produto = carregarProdutoMok();
        }

        [Fact]
        public void AtualizarEstoqueProdutoPositivoTest()
        {
            _produto.AtualizarEstoqueProduto(1);
            Assert.True(_produto.QuantidadeEstoque == 51);
        }

        [Fact]
        public void AtualizarEstoqueProdutoNegativoTest()
        {
            _produto.AtualizarEstoqueProduto(-1);
            Assert.True(_produto.QuantidadeEstoque == 49);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void AtualizarEstoqueProdutoTest(int quantidadeAtualizar)
        {
            var quantidadeEstoqueAtual = _produto.QuantidadeEstoque;
            _produto.AtualizarEstoqueProduto(quantidadeAtualizar);
            Assert.True(quantidadeEstoqueAtual == (_produto.QuantidadeEstoque + quantidadeAtualizar));
        }

        private Produto carregarProdutoMok()
        {
            return new Produto()
            {
                ProdutoID = 1,
                Codigo = "123A",
                CodigoInterno = "456A",
                Descricao = "Produto Mock",
                UnidadeVenda = UnidadesCompraVenda.Caixa.ToString(),
                PrecoCusto = (decimal)1.50,
                PrecoVenda = (decimal)2.50,
                QuantidadeEstoque = 50,
                Status = true,
                SecaoProdutoID = 1,
                UsuarioInclusao = "Admin",
                DataInclusao = DateTime.Now,
                UsuarioAltracao = "Admin",
                DataAlteracao = DateTime.Now,
                SecaoProduto = null,
                PedidoItem = null
            };
        }
    }
}
