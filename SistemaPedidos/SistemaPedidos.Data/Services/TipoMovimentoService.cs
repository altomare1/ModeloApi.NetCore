using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Repositories;
using SistemaPedidos.Domain.Interfaces.Services;

namespace SistemaPedidos.Data.Services
{
    public class TipoMovimentoService : ServiceBase<TipoMovimento>, ITipoMovimentoService
    {
        private readonly ITipoMovimentoRepository _serviceRepository;

        public TipoMovimentoService(ITipoMovimentoRepository serviceRepository)
            : base(serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
    }
}
