using SistemaPedidos.Domain.Entities;
using System.Collections.Generic;

namespace SistemaPedidos.Application.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}
