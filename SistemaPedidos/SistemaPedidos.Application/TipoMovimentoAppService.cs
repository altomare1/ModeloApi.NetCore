using SistemaPedidos.Application.Interface;
using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Services;

namespace SistemaPedidos.Application
{
    public class TipoMovimentoAppService : AppServiceBase<TipoMovimento>, ITipoMovimentoAppService
    {
        private readonly ITipoMovimentoService _appService;

        public TipoMovimentoAppService(ITipoMovimentoService appService)
            : base(appService)
        {
            _appService = appService;
        }
    }
}
