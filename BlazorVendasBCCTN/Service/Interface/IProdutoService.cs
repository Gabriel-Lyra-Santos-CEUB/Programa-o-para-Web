using BlazorVendasBCCTN.Entities;

namespace BlazorVendasBCCTN.Service.Interface
{
    public interface IProdutoService
    {
        Task AdicionarAsync(Produto produto);
        Task AlterarAsync(Produto produto);
        Task ExcluirAsync(int id);
        Task<IEnumerable<Produto>> ListarTodosProdutosAsync();
        Task<Produto> PesquisarProdutoPorIdAsync(int id);
    }
}
