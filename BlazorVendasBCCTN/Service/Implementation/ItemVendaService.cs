using BlazorVendasBCCTN.Data.Context;
using BlazorVendasBCCTN.Entities;

namespace BlazorVendasBCCTN.Service.Interface
{
    public class ItemVendaService: IItemVendaService
    {
        private SQLServerContext _context;
        public ItemVendaService(SQLServerContext context)
        {
            _context = context;
        }

        public Task ExcluirItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task InserirItemAsync(ItemVenda itemVenda)
        {
            throw new NotImplementedException();
        }
    }
}
