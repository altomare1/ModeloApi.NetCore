using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Repositories;
using SistemaPedidos.Domain.Interfaces.Services;

namespace SistemaPedidos.Data.Services
{
    public class FormaPagamentoService : ServiceBase<FormaPagamento>, IFormaPagamentoService
    {
        private readonly IFormaPagamentoRepository _serviceRepository;

        public FormaPagamentoService(IFormaPagamentoRepository serviceRepository)
            : base(serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
    }
}
