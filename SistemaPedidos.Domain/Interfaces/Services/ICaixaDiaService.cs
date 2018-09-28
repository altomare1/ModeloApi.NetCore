using SistemaPedidos.Domain.Entities;

namespace SistemaPedidos.Domain.Interfaces.Services
{
    public interface ICaixaDiaService : IServiceBase<CaixaDia>
    {
        CaixaDia PreencherTotaisPorFormaPagamento(int idCaixa);
    }
}
