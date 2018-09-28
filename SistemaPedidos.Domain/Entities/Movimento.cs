using SistemaPedidos.Utils.Enums;
using System;

namespace SistemaPedidos.Domain.Entities
{
    public class Movimento
    {
        public int MovimentoID { get; set; }
        public decimal Valor { get; set; } //Pegar valor do excel da venda - cadastrar no produto o valor minimo de venda e sinalizar se alguma venda ficar menor
        public DateTime DataEmissao { get; set; }
        public DateTime DataVencimento { get; set; }
        public bool Status { get; set; }
        public int TipoOperacao { get; set; }
        public int? NumeroCheque { get; set; }
        public int? CodigoBancoCheque { get; set; }
        public bool? PossuiNota { get; set; }
        public int? PedidoID { get; set; }
        public int CaixaDiaID { get; set; }
        public int TipoMovimentoID { get; set; }
        public int FormaPagamentoID { get; set; }
        public int? FornecedorID { get; set; }
        public int? ClienteID { get; set; }
        public int FuncionarioID { get; set; }
        public string UsuarioInclusao { get; set; }
        public DateTime DataInclusao { get; set; }
        public string UsuarioAltracao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public virtual Pedido Pedido { get; set; }
        public virtual CaixaDia CaixaDia { get; set; } 
        public virtual TipoMovimento TipoMovimento { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Funcionario Funcionario { get; set; }

        public bool VerficarInadimplencia()
        {
            return DataVencimento < DateTime.Now && !Status;
        }
    }
}
