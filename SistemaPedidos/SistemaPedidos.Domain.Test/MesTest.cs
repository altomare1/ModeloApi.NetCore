using SistemaPedidos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xunit;

namespace SistemaPedidos.Domain.Test
{
    public class MesTest
    {
        private Mes _mes;
        private ICollection<CaixaDia> _caixas;

        public MesTest()
        {
            _caixas = PreencherCaixasMesMock();
            _mes = PreencherMesMock(_caixas);
        }

        [Fact]
        public void AtualizarSaldoTest()
        {
            Assert.True(_mes.AtualizarSaldo(100));
        }

        [Fact]
        public void AtualizarSaldoExceptionTest()
        {
            Assert.Throws<Exception>(() => _mes.AtualizarSaldo(150));
        }

        [Fact]
        public void FecharMesTest()
        {
            Assert.True(_mes.FecharMes());
        }

        [Fact]
        public void FecharMesErroTest()
        {
            _mes.Dias.Add(AdiconarCaixaAberto());
            Assert.False(_mes.FecharMes());
        }

        private CaixaDia AdiconarCaixaAberto()
        {
            return new CaixaDia()
            {
                CaixaDiaID = 5,
                DataCaixa = DateTime.Now,
                Responsavel = "",
                Status = false,
                DataFechamento = DateTime.Now,
                Saldo = 0,
                TotalDinheiro = 50,
                TotalCheque = 50,
                TotalCartaoDebito = 50,
                TotalCartaoCredito = 50,
                TotalBoleto = 50,
                MesID = 1,
                UsuarioInclusao = "Admin",
                DataInclusao = DateTime.Now,
                UsuarioAltracao = String.Empty,
                DataAlteracao = DateTime.Now,
                Mes = null,
                Movimentos = null,
                TotalSaldoCaixa = 150,
                TotalReceitas = 250,
                TotalDespesas = 100,
            };
        }

        private ICollection<CaixaDia> PreencherCaixasMesMock()
        {
            return new Collection<CaixaDia>()
            {
                new CaixaDia()
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
                    UsuarioInclusao = "Admin",
                    DataInclusao = DateTime.Now,
                    UsuarioAltracao = String.Empty,
                    DataAlteracao = DateTime.Now,
                    Mes = null,
                    Movimentos = null,
                    TotalSaldoCaixa = -50,
                    TotalReceitas = 50,
                    TotalDespesas = 100,
                },
                new CaixaDia()
                {
                    CaixaDiaID = 2,
                    DataCaixa = DateTime.Now,
                    Responsavel = "",
                    Status = true,
                    DataFechamento = DateTime.Now,
                    Saldo = 0,
                    TotalDinheiro = 20,
                    TotalCheque = 20,
                    TotalCartaoDebito = 20,
                    TotalCartaoCredito = 20,
                    TotalBoleto = 20,
                    MesID = 1,
                    UsuarioInclusao = "Admin",
                    DataInclusao = DateTime.Now,
                    UsuarioAltracao = String.Empty,
                    DataAlteracao = DateTime.Now,
                    Mes = null,
                    Movimentos = null,
                    TotalSaldoCaixa = 0,
                    TotalReceitas = 100,
                    TotalDespesas = 100,
                },
                new CaixaDia()
                {
                    CaixaDiaID = 3,
                    DataCaixa = DateTime.Now,
                    Responsavel = "",
                    Status = true,
                    DataFechamento = DateTime.Now,
                    Saldo = 0,
                    TotalDinheiro = 30,
                    TotalCheque = 30,
                    TotalCartaoDebito = 30,
                    TotalCartaoCredito = 30,
                    TotalBoleto = 30,
                    MesID = 1,
                    UsuarioInclusao = "Admin",
                    DataInclusao = DateTime.Now,
                    UsuarioAltracao = String.Empty,
                    DataAlteracao = DateTime.Now,
                    Mes = null,
                    Movimentos = null,
                    TotalSaldoCaixa = 50,
                    TotalReceitas = 150,
                    TotalDespesas = 100,
                },
                new CaixaDia()
                {
                    CaixaDiaID = 4,
                    DataCaixa = DateTime.Now,
                    Responsavel = "",
                    Status = true,
                    DataFechamento = DateTime.Now,
                    Saldo = 0,
                    TotalDinheiro = 40,
                    TotalCheque = 40,
                    TotalCartaoDebito = 40,
                    TotalCartaoCredito = 40,
                    TotalBoleto = 40,
                    MesID = 1,
                    UsuarioInclusao = "Admin",
                    DataInclusao = DateTime.Now,
                    UsuarioAltracao = String.Empty,
                    DataAlteracao = DateTime.Now,
                    Mes = null,
                    Movimentos = null,
                    TotalSaldoCaixa = 100,
                    TotalReceitas = 200,
                    TotalDespesas = 100
                }
            };
        }

        private Mes PreencherMesMock(ICollection<CaixaDia> caixas)
        {
            return new Mes() {
                MesID = 1,
                MesReferencia = "07/2018",
                DataFechamento = DateTime.Now,
                Responsavel = "Admin",
                Status = false,
                Despesas = 400,
                Receitas = 500,
                SaldoMes = 100,
                SaldoMesAnterior = 100,
                UsuarioInclusao = "Admin",
                DataInclusao = DateTime.Now,
                UsuarioAltracao = "Admin",
                DataAlteracao = DateTime.Now,
                Dias = caixas
            };
        }
    }
}
