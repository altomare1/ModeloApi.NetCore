using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Repositories;
using SistemaPedidos.Domain.Interfaces.Services;

namespace SistemaPedidos.Data.Services
{
    public class InventarioProdutoService : ServiceBase<InventarioProduto>, IInventarioProdutoService
    {
        private readonly IInventarioProdutoRepository _serviceRepository;

        public InventarioProdutoService(IInventarioProdutoRepository serviceRepository)
            : base(serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
    }
}
