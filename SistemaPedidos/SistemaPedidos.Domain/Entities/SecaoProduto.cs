using System;
using System.Collections.Generic;

namespace SistemaPedidos.Domain.Entities
{
    public class SecaoProduto
    {
        public int SecaoProdutoID { get; set; }
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public bool Status { get; set; }
        public string UsuarioInclusao { get; set; }
        public DateTime DataInclusao { get; set; }
        public string UsuarioAltracao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public virtual ICollection<Produto> Produto { get; set; }
    }
}
