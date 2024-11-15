using BlazorVendasBCCTN.Data.Context;
using BlazorVendasBCCTN.Entities;

namespace BlazorVendasBCCTN.Service.Interface
{
    public class PedidoService : IPedidoService
    {
        private SQLServerContext _context;
        public PedidoService(SQLServerContext context)
        {
            _context = context;
        }

        public Task AdicionarAsync(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task AlterarAsync(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task ExcluirAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cliente>> ListarTodosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pedido>> ListarVendasAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> PesquisarPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> PesquisarPorNomeAsync(string nome)
        {
            throw new NotImplementedException();
        }

        public Task RegistrarVendaAsync(Pedido pedido)
        {
            throw new NotImplementedException();
        }
    }
}
