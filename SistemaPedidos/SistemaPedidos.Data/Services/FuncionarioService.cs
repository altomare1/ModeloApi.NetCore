using SistemaPedidos.Domain.Entities;
using SistemaPedidos.Domain.Interfaces.Repositories;
using SistemaPedidos.Domain.Interfaces.Services;

namespace SistemaPedidos.Data.Services
{
    public class FuncionarioService : ServiceBase<Funcionario>, IFuncionarioService
    {
        private readonly IFuncionarioRepository _serviceRepository;

        public FuncionarioService(IFuncionarioRepository serviceRepository) 
            : base(serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
    }
}
