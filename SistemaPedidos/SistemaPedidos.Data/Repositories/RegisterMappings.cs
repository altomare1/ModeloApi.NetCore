using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;
using SistemaPedidos.Data.Mappers;

namespace SistemaPedidos.Data.Repositories
{
    public static class RegisterMappings
    {
        public static void Register()
        {
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new FuncionarioMap());
                config.ForDommel();
            });
        }
    }
}
