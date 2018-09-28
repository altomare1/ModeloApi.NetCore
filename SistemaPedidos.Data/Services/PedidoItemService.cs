using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Repositories;
using SistemaPedidos.Domain.Interfaces.Services;

namespace SistemaPedidos.Data.Services
{
    public class PedidoItemService : ServiceBase<PedidoItem>, IPedidoItemService
    {
        private readonly IPedidoItemRepository _serviceRepository;

        public PedidoItemService(IPedidoItemRepository serviceRepository)
            : base(serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
    }
}
