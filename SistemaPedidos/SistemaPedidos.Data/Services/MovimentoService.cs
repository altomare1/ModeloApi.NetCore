using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Repositories;
using SistemaPedidos.Domain.Interfaces.Services;

namespace SistemaPedidos.Data.Services
{
    public class MovimentoService : ServiceBase<Movimento>, IMovimentoService
    {
        private readonly IMovimentoRepository _serviceRepository;

        public MovimentoService(IMovimentoRepository serviceRepository)
            : base(serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
    }
}
