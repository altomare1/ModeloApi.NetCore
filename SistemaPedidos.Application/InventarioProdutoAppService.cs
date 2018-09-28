using SistemaPedidos.Application.Interface;
using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Services;

namespace SistemaPedidos.Application
{
    public class InventarioProdutoAppService : AppServiceBase<InventarioProduto>, IInventarioProdutoAppService
    {
        private readonly IInventarioProdutoService _appService;

        public InventarioProdutoAppService(IInventarioProdutoService appService)
            : base(appService)
        {
            _appService = appService;
        }
    }
}
