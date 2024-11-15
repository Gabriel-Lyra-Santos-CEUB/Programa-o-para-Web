using BlazorVendasBCCTN.Data.Context;
using BlazorVendasBCCTN.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorVendasBCCTN.Service.Interface
{
    public class ClienteService: IClienteService
    {
        private SQLServerContext _context;

        public async Task AdicionarAsync(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task AlterarAsync(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            await _context.SaveChangesAsync();
        }

        public async Task ExcluirAsync(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Cliente>> ListarTodosAsync()
        {
            return await _context.Clientes.ToListAsync();
        }

        public async Task<Cliente> PesquisarPorIdAsync(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }

        public async Task<Cliente> PesquisarPorNomeAsync(string nome)
        {
            return await _context.Clientes.FindAsync(nome);
        }
    }
}
