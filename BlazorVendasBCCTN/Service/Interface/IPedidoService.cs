using BlazorVendasBCCTN.Entities;

namespace BlazorVendasBCCTN.Service.Interface
{
    public interface IPedidoService
    {
        Task RegistrarVendaAsync(Pedido pedido);
        Task<IEnumerable<Pedido>> ListarVendasAsync();
    }
}
