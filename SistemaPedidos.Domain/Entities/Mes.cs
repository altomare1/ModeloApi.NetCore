using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaPedidos.Domain.Entities
{
    public class Mes
    {
        public int MesID { get; set; }
        public string MesReferencia { get; set; }
        public DateTime? DataFechamento { get; set; }
        public string Responsavel { get; set; }
        public bool Status { get; set; }
        public decimal Despesas { get; set; }
        public decimal Receitas { get; set; }
        public decimal SaldoMes { get; set; }
        public decimal SaldoMesAnterior { get; set; }
        public string UsuarioInclusao { get; set; }
        public DateTime DataInclusao { get; set; }
        public string UsuarioAltracao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public virtual ICollection<CaixaDia> Dias { get; set; }

        public bool AtualizarSaldo(decimal valorAtualizar)
        {
            if (valorAtualizar == (Receitas - Despesas))
                SaldoMes = valorAtualizar;
            else
                throw new Exception("Valores de despesa e receita não atualizados, munça não permitida");

            return true;
        }

        public bool FecharMes()
        {
            bool caixasFechados = true;
            Dias.ToList().ForEach(delegate (CaixaDia caixa)
            {
                if(!caixa.Status)
                    caixasFechados = caixa.Status;
            });

            Status = caixasFechados;
            return Status;
        }
    }
}
