using SistemaPedidos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SistemaPedidos.Domain.Test
{
    public class InventarioProdutoTest
    {
        private InventarioProduto _inventarioProduto;

        public InventarioProdutoTest()
        {
            _inventarioProduto = PreencherInventarioProdutoMock();
        }

        [Fact]
        public void CalcularSaldoContabilTest()
        {
            var valorContabil = _inventarioProduto.CalcularSaldoContabil((decimal)2.50);
            Assert.True(valorContabil == (decimal)75.00);
        }

        [Fact]
        public void CalcularDiferencaEstoqueTest()
        {
            var quantidadeEstoque = _inventarioProduto.CalcularDiferencaEstoque();
            Assert.True(quantidadeEstoque == 30);
        }

        private InventarioProduto PreencherInventarioProdutoMock()
        {
            return new InventarioProduto()
            {
                InventarioProdutoID = 1,
                ProdutoID = 1,
                DataInventario = DateTime.Now,
                EstoqueSistema = 50,
                EstoqueContabil = 20,
                SaldoContabil = (decimal)125.00,
                Observacoes = "",
                Status = true,
                UsuarioInclusao = "Admin",
                DataInclusao = DateTime.Now,
                UsuarioAltracao = "Admin",
                DataAlteracao = DateTime.Now,
                NomeProduto = "Teste Produto Mock",
                QuantidadeEstoque = 50
            };
        }
    }
}
