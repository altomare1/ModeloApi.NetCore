using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Repositories;
using SistemaPedidos.Domain.Interfaces.Services;

namespace SistemaPedidos.Data.Services
{
    public class SecaoProdutoService : ServiceBase<SecaoProduto>, ISecaoProdutoService
    {
        private readonly ISecaoProdutoRepository _serviceRepository;

        public SecaoProdutoService(ISecaoProdutoRepository serviceRepository)
            : base(serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
    }
}
