using BlazorVendasBCCTN.Data.Context;
using BlazorVendasBCCTN.Entities;

namespace BlazorVendasBCCTN.Service.Interface
{
    public class ProdutoService: IProdutoService
    {
        private SQLServerContext _context;
        public ProdutoService(SQLServerContext context)
        {
            _context = context;
        }

        public Task AdicionarAsync(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task AlterarAsync(Produto produto)
        {
            throw new NotImplementedException();
        }

        public Task ExcluirAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Produto>> ListarTodosProdutosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Produto> PesquisarProdutoPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
