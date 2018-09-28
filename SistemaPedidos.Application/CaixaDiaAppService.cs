using SistemaPedidos.Application.Interface;
using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Services;

namespace SistemaPedidos.Application
{
    public class CaixaDiaAppService : AppServiceBase<CaixaDia>, ICaixaDiaAppService
    {
        private readonly ICaixaDiaService _appService;

        public CaixaDiaAppService(ICaixaDiaService appService)
            : base(appService)
        {
            _appService = appService;
        }

        public CaixaDia PreencheTotaisPorFormaPagamento(int idCaixa)
        {
            return _appService.PreencherTotaisPorFormaPagamento(idCaixa);
        }
    }
}
