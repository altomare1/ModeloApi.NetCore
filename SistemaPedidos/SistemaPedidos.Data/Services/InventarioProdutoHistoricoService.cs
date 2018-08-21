using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Repositories;
using SistemaPedidos.Domain.Interfaces.Services;

namespace SistemaPedidos.Data.Services
{
    public class InventarioProdutoHistoricoService : ServiceBase<InventarioProdutoHistorico>, IInventarioProdutoHistoricoService
    {
        private readonly IInventarioProdutoHistoricoRepository _serviceRepository;

        public InventarioProdutoHistoricoService(IInventarioProdutoHistoricoRepository serviceRepository)
            : base(serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
    }
}
