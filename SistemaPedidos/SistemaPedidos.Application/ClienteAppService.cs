using SistemaPedidos.Application.Interface;
using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace SistemaPedidos.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _appService;

        public ClienteAppService(IClienteService appService)
            : base(appService)
        {
            _appService = appService;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais()
        {
            return _appService.ObterClientesEspeciais();
        }
    }
}
