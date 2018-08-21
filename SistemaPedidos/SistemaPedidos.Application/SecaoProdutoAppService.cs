using SistemaPedidos.Application.Interface;
using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Services;

namespace SistemaPedidos.Application
{
    public class SecaoProdutoAppService : AppServiceBase<SecaoProduto>, ISecaoProdutoAppService
    {
        private readonly ISecaoProdutoService _appService;

        public SecaoProdutoAppService(ISecaoProdutoService appService)
            : base(appService)
        {
            _appService = appService;
        }
    }
}
