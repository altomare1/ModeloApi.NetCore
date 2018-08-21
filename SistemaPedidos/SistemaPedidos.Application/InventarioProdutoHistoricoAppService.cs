using SistemaPedidos.Application.Interface;
using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Services;

namespace SistemaPedidos.Application
{
    public class InventarioProdutoHistoricoAppService : AppServiceBase<InventarioProdutoHistorico>, IInventarioProdutoHistoricoAppService
    {
        private readonly IInventarioProdutoHistoricoService _appService;

        public InventarioProdutoHistoricoAppService(IInventarioProdutoHistoricoService appService)
            : base(appService)
        {
            _appService = appService;
        }
    }
}
