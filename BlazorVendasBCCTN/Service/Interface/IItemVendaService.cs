using BlazorVendasBCCTN.Entities;

namespace BlazorVendasBCCTN.Service.Interface
{
    public interface IItemVendaService
    {
        Task InserirItemAsync(ItemVenda itemVenda);
        Task ExcluirItemAsync(int id);
    }
}
