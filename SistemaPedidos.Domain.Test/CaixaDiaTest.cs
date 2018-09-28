using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xunit;

namespace SistemaPedidos.Domain.Test
{
    public class CaixaDiaTest
    {
        private CaixaDia _caixaDia;

        public CaixaDiaTest()
        {
            var movimentos = PreencherMomvimentosCaixaMock();
            _caixaDia = PreencherCaixaDiaMock(movimentos);
        }

        [Fact]
        public void PreencherTotaisPorFormaPagamentoTest()
        {
            _caixaDia.PreencherTotaisPorFormaPagamento();
            Assert.True(_caixaDia.TotalCartaoDebito == 20);
            Assert.True(_caixaDia.TotalDinheiro == 30);
        }
        
        [Fact]
        public void SomarTotalReceitasTest()
        {
            var totalReceitas = _caixaDia.SomarTotalReceitas();
            Assert.True(totalReceitas == 50);
        }

        [Fact]
        public void SomarTotalDespesasTest()
        {
            var totalDespesas = _caixaDia.SomarTotalDespesas();
            Assert.True(totalDespesas == 50);
        }

        [Fact]
        public void SomarTotalDespesasSemMovimentoTest()
        {
            _caixaDia.Movimentos = null;
            var totalDespesas = _caixaDia.SomarTotalDespesas();
            Assert.True(totalDespesas == 0);
        }

        [Fact]
        public void CalcularSaldoCaixaTest()
        {
            var saldoCaixa = _caixaDia.CalcularSaldoCaixa();
            Assert.True(saldoCaixa == 0);
        }

        [Fact]
        public void AtualizarSaldoTest()
        {
            _caixaDia.AtualizarSaldo(100);
            Assert.True(_caixaDia.TotalSaldoCaixa == 100);
        }

        [Fact]
        public void FecharCaixaTest()
        {
            Assert.True(_caixaDia.FecharCaixa());
        }

        private ICollection<Movimento> PreencherMomvimentosCaixaMock()
        {
            return new Collection<Movimento>()
            {
                new Movimento()
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
                },
                new Movimento()
                {
                    MovimentoID = 1,
                    Valor = 30,
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
                    FormaPagamentoID = (int)FormasPagamento.Dinheiro,
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
                },new Movimento()
                {
                    MovimentoID = 1,
                    Valor = 20,
                    DataEmissao = DateTime.Now,
                    DataVencimento = DateTime.Now,
                    Status = true,
                    TipoOperacao = (int)Operacoes.Despesa,
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
                },
                new Movimento()
                {
                    MovimentoID = 1,
                    Valor = 30,
                    DataEmissao = DateTime.Now,
                    DataVencimento = DateTime.Now,
                    Status = true,
                    TipoOperacao = (int)Operacoes.Despesa,
                    NumeroCheque = null,
                    CodigoBancoCheque = null,
                    PossuiNota = false,
                    PedidoID = 1,
                    CaixaDiaID = 1,
                    TipoMovimentoID = 1,
                    FormaPagamentoID = (int)FormasPagamento.Dinheiro,
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
                }
            };
        }

        private CaixaDia PreencherCaixaDiaMock(ICollection<Movimento> movimentos)
        {
            return new CaixaDia()
            {
                CaixaDiaID = 1,
                DataCaixa = DateTime.Now,
                Responsavel = "",
                Status = true,
                DataFechamento = DateTime.Now,
                Saldo = 0,
                TotalDinheiro = 10,
                TotalCheque = 10,
                TotalCartaoDebito = 10,
                TotalCartaoCredito = 10,
                TotalBoleto = 10,
                MesID = 1,
                UsuarioInclusao = "",
                DataInclusao = DateTime.Now,
                UsuarioAltracao = "",
                DataAlteracao = DateTime.Now,
                Mes = null,
                Movimentos = movimentos,
                TotalSaldoCaixa = 0,
                TotalReceitas = 0,
                TotalDespesas = 0,
            };
        }
    }
}
