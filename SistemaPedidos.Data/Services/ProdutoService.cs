using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Repositories;
using SistemaPedidos.Domain.Interfaces.Services;

namespace SistemaPedidos.Data.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _serviceRepository;

        public ProdutoService(IProdutoRepository serviceRepository)
            : base(serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
    }
}
