using SistemaPedidos.Application.Interface;
using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Services;

namespace SistemaPedidos.Application
{
    public class MovimentoAppService : AppServiceBase<Movimento>, IMovimentoAppService
    {
        private readonly IMovimentoService _appService;

        public MovimentoAppService(IMovimentoService appService)
            : base(appService)
        {
            _appService = appService;
        }
    }
}
