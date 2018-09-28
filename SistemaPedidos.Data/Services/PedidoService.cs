using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Repositories;
using SistemaPedidos.Domain.Interfaces.Services;

namespace SistemaPedidos.Data.Services
{
    public class PedidoService : ServiceBase<Pedido>, IPedidoService
    {
        private readonly IPedidoRepository _serviceRepository;

        public PedidoService(IPedidoRepository serviceRepository)
            : base(serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
    }
}
