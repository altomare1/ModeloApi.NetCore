using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Repositories;
using SistemaPedidos.Domain.Interfaces.Services;

namespace SistemaPedidos.Data.Services
{
    public class CaixaDiaService : ServiceBase<CaixaDia>, ICaixaDiaService
    {
        private readonly ICaixaDiaRepository _serviceRepository;

        public CaixaDiaService(ICaixaDiaRepository serviceRepository)
            : base(serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public CaixaDia PreencherTotaisPorFormaPagamento(int idCaixa)
        {
            var caixaDia = _serviceRepository.GetById(idCaixa);
            caixaDia.PreencherTotaisPorFormaPagamento();
            return caixaDia;
        }
    }
}