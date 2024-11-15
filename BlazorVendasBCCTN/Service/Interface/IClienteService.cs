using BlazorVendasBCCTN.Data.Context;
using BlazorVendasBCCTN.Entities;

namespace BlazorVendasBCCTN.Service.Interface
{
    public interface IClienteService
    {
        Task AdicionarAsync(Cliente cliente);
        Task AlterarAsync(Cliente cliente);
        Task ExcluirAsync(int id);
        Task<IEnumerable<Cliente>> ListarTodosAsync();
        Task<Cliente> PesquisarPorIdAsync(int id);
        Task<Cliente> PesquisarPorNomeAsync(string nome);
    }
}
