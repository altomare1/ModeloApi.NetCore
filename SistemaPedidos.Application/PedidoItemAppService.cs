using SistemaPedidos.Application.Interface;
using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Services;

namespace SistemaPedidos.Application
{
    public class PedidoItemAppService : AppServiceBase<PedidoItem>, IPedidoItemAppService
    {
        private readonly IPedidoItemService _appService;

        public PedidoItemAppService(IPedidoItemService appService)
            : base(appService)
        {
            _appService = appService;
        }
    }
}
