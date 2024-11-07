using BlazorVendasBCCTN.Data.Context;
using BlazorVendasBCCTN.Entities;

namespace BlazorVendasBCCTN.Service.Interface
{
    public class FuncionarioService : IFuncionarioService
    {
        private SQLServerContext _context;

        public FuncionarioService(SQLServerContext context)
        {
            _context = context;
        }

        public Task AdicionarAsync(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public Task AlterarAsync(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public Task ExcluirAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Funcionario>> ListarTodosAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Funcionario> PesquisarPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Funcionario> PesquisarPorNomeAsync(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
