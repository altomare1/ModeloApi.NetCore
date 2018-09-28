using SistemaPedidos.Domain.Entities;
using System.Collections.Generic;

namespace SistemaPedidos.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}
