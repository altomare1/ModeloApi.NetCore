using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SistemaPedidos.Domain.Test
{
    public class MovimentoTest
    {
        private Movimento _movimento;

        public MovimentoTest()
        {
            _movimento = PreencherMomvimentoMock();
        }

        [Fact]
        public void VerficarMovimentoInadimplenteTest()
        {
            _movimento.DataVencimento = DateTime.Now.AddDays(-1);
            _movimento.Status = false;
            Assert.True(_movimento.VerficarInadimplencia());
        }

        [Fact]
        public void VerficarMovimentoVencidoPagoTest()
        {
            _movimento.DataVencimento = DateTime.Now.AddDays(-1);
            _movimento.Status = true;
            Assert.False(_movimento.VerficarInadimplencia());
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void VerficarMovimentoNaoInadimplenteTest(bool pago)
        {
            _movimento.DataVencimento = DateTime.Now.AddDays(1);
            _movimento.Status = pago;
            Assert.False(_movimento.VerficarInadimplencia());
        }

        private Movimento PreencherMomvimentoMock()
        {
            return new Movimento()
            {
                MovimentoID = 1,
                Valor = 20,
                DataEmissao = DateTime.Now,
                DataVencimento = DateTime.Now,
                Status = true,
                TipoOperacao = (int)Operacoes.Receita,
                NumeroCheque = null,
                CodigoBancoCheque = null,
                PossuiNota = false,
                PedidoID = 1,
                CaixaDiaID = 1,
                TipoMovimentoID = 1,
                FormaPagamentoID = (int)FormasPagamento.CartaoDebito,
                FornecedorID = 1,
                ClienteID = 1,
                FuncionarioID = 1,
                UsuarioInclusao = "Admin",
                DataInclusao = DateTime.Now,
                UsuarioAltracao = String.Empty,
                DataAlteracao = DateTime.Now,
                Pedido = null,
                CaixaDia = null,
                TipoMovimento = null,
                FormaPagamento = null,
                Fornecedor = null,
                Cliente = null,
                Funcionario = null
            };
        }   
    }
}
