using SistemaPedidos.Application.Interface;
using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Services;

namespace SistemaPedidos.Application
{
    public class ComissaoFuncionarioAppService : AppServiceBase<ComissaoFuncionario>, IComissaoFuncionarioAppService
    {
        private readonly IComissaoFuncionarioService _appService;

        public ComissaoFuncionarioAppService(IComissaoFuncionarioService appService)
            : base(appService)
        {
            _appService = appService;
        }
    }
}
