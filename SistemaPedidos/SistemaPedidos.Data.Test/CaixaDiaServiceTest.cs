using Moq;
using SistemaPedidos.Data.Services;
using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Repositories;
using SistemaPedidos.Domain.Interfaces.Services;
using SistemaPedidos.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xunit;

namespace SistemaPedidos.Data.Test
{
    public class CaixaDiaServiceTest
    {
        private CaixaDia _caixaDia;
        private ICaixaDiaService _appService;
        private Mock<ICaixaDiaRepository> caixaDiaRepositoryMock = new Mock<ICaixaDiaRepository>();

        public CaixaDiaServiceTest()
        {
            var movimentos = PreencherMovimentosCaixaMock();
            _caixaDia = PreencherCaixaDiaMock(movimentos);
            _appService = new CaixaDiaService(caixaDiaRepositoryMock.Object);
        }

        [Fact]
        public void PreencherTotaisPorFormaPagamentoServiceTest()
        {
            caixaDiaRepositoryMock.Setup(x => x.GetById(1)).Returns(_caixaDia);
            _appService.PreencherTotaisPorFormaPagamento(1);
            Assert.True(_caixaDia.TotalCartaoDebito == 20);
            Assert.True(_caixaDia.TotalDinheiro == 10);
        }

        private ICollection<Movimento> PreencherMovimentosCaixaMock()
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
                    Valor = 10,
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
