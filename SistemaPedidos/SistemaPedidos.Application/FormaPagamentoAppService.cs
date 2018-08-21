using SistemaPedidos.Application.Interface;
using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Services;

namespace SistemaPedidos.Application
{
    public class FormaPagamentoAppService : AppServiceBase<FormaPagamento>, IFormaPagamentoAppService
    {
        private readonly IFormaPagamentoService _appService;

        public FormaPagamentoAppService(IFormaPagamentoService appService)
            : base(appService)
        {
            _appService = appService;
        }
    }
}
