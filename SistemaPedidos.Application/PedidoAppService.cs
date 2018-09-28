using SistemaPedidos.Application.Interface;
using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Services;

namespace SistemaPedidos.Application
{
    public class PedidoAppService : AppServiceBase<Pedido>, IPedidoAppService
    {
        private readonly IPedidoService _appService;

        public PedidoAppService(IPedidoService appService)
            : base(appService)
        {
            _appService = appService;
        }
    }
}
