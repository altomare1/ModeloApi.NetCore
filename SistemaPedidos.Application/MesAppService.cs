using SistemaPedidos.Application.Interface;
using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Services;

namespace SistemaPedidos.Application
{
    public class MesAppService : AppServiceBase<Mes>, IMesAppService
    {
        private readonly IMesService _appService;

        public MesAppService(IMesService appService)
            : base(appService)
        {
            _appService = appService;
        }
    }
}
