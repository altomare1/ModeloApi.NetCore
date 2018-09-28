using SistemaPedidos.Application.Interface;
using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Services;

namespace SistemaPedidos.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _appService;

        public ProdutoAppService(IProdutoService appService)
            : base(appService)
        {
            _appService = appService;
        }
    }
}
