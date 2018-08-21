using SistemaPedidos.Domain.Entities;

namespace SistemaPedidos.Application.Interface
{
    public interface ICaixaDiaAppService : IAppServiceBase<CaixaDia>
    {
        CaixaDia PreencheTotaisPorFormaPagamento(int idCaixa);
    }
}
