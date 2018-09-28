using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Repositories;
using SistemaPedidos.Domain.Interfaces.Services;

namespace SistemaPedidos.Data.Services
{
    public class FornecedorService : ServiceBase<Fornecedor>, IFornecedorService
    {
        private readonly IFornecedorRepository _serviceRepository;

        public FornecedorService(IFornecedorRepository serviceRepository)
            : base(serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
    }
}
