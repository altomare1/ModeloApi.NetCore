using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Repositories;
using SistemaPedidos.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace SistemaPedidos.Data.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _serviceRepository;

        public ClienteService(IClienteRepository serviceRepository)
            : base(serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais()
        {
            IEnumerable<Cliente> clientes = _serviceRepository.GetAll();
            return clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}
