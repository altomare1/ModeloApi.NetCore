using SistemaPedidos.Utils.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaPedidos.Domain.Entities
{
    public class CaixaDia
    {
        public int CaixaDiaID { get; set; }
        public DateTime DataCaixa { get; set; }
        public string Responsavel { get; set; }
        public bool Status { get; set; }
        public DateTime? DataFechamento { get; set; }
        public decimal Saldo { get; set; }
        public decimal TotalDinheiro { get; set; }
        public decimal TotalCheque { get; set; }
        public decimal TotalCartaoDebito { get; set; }
        public decimal TotalCartaoCredito { get; set; }
        public decimal TotalBoleto { get; set; }
        public int MesID { get; set; }
        public string UsuarioInclusao { get; set; }
        public DateTime DataInclusao { get; set; }
        public string UsuarioAltracao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public virtual Mes Mes { get; set; }
        public virtual ICollection<Movimento> Movimentos { get; set; }

        public decimal TotalSaldoCaixa { get; set; }
        public decimal TotalReceitas { get; set; }
        public decimal TotalDespesas { get; set; }

        public void PreencherTotaisPorFormaPagamento()
        {
            TotalDinheiro = 0;
            TotalCheque = 0;
            TotalCartaoDebito = 0;
            TotalCartaoCredito = 0;
            TotalBoleto = 0;
            if (Movimentos != null)
            {
                foreach (var receita in Movimentos.Where(x => x.TipoOperacao.Equals((int)Operacoes.Receita)))
                {
                    if (receita.FormaPagamentoID.Equals((int)FormasPagamento.Dinheiro))
                    {
                        TotalDinheiro += receita.Valor;
                    }
                    else if (receita.FormaPagamentoID.Equals((int)FormasPagamento.CartaoCredito))
                    {
                        TotalCartaoCredito += receita.Valor;
                    }
                    else if (receita.FormaPagamentoID.Equals((int)FormasPagamento.CartaoDebito))
                    {
                        TotalCartaoDebito += receita.Valor;
                    }
                    else if (receita.FormaPagamentoID.Equals((int)FormasPagamento.Cheque))
                    {
                        TotalCheque += receita.Valor;
                    }
                    else if (receita.FormaPagamentoID.Equals((int)FormasPagamento.Boleto))
                    {
                        TotalBoleto += receita.Valor;
                    }
                }
            }
        }

        public decimal SomarTotalReceitas()
        {
            return Saldo + TotalDinheiro + TotalCheque + TotalCartaoDebito + TotalCartaoCredito + TotalBoleto;
        }

        public decimal SomarTotalDespesas()
        {
            decimal total = 0;
            if (Movimentos != null)
            {
                foreach (var despesa in Movimentos.Where(x => x.TipoOperacao.Equals((int)Operacoes.Despesa)))
                {
                    total += despesa.Valor;
                }
            }

            return total;
        }

        public decimal CalcularSaldoCaixa()
        {
            return (SomarTotalReceitas() - SomarTotalDespesas());
        }

        public void AtualizarSaldo(decimal valorAtualizado)
        {
            TotalSaldoCaixa = valorAtualizado;
        }
        
        public bool FecharCaixa()
        {
            Status = true;
            return Status;
        }
    }
}
