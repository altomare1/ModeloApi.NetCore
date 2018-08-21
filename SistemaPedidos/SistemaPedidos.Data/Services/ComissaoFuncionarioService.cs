using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Repositories;
using SistemaPedidos.Domain.Interfaces.Services;

namespace SistemaPedidos.Data.Services
{
    public class ComissaoFuncionarioService : ServiceBase<ComissaoFuncionario>, IComissaoFuncionarioService
    {
        private readonly IComissaoFuncionarioRepository _serviceRepository;

        public ComissaoFuncionarioService(IComissaoFuncionarioRepository serviceRepository)
            : base(serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
    }
}
