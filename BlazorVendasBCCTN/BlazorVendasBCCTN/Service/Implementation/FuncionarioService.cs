﻿using BlazorVendasBCCTN.Data.Context;
using BlazorVendasBCCTN.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorVendasBCCTN.Service.Interface
{
    public class FuncionarioService : IFuncionarioService
    {
        private SQLServerContext _context;

        public FuncionarioService(SQLServerContext context)
        {
            _context = context;
        }

        public async Task AdicionarAsync(Funcionario funcionario)
        {
            _context.Funcionarios.Add(funcionario);
            await _context.SaveChangesAsync();
        }

        public async Task AlterarAsync(Funcionario funcionario)
        {
            _context.Funcionarios.Update(funcionario);
            await _context.SaveChangesAsync();
        }

        public async Task ExcluirAsync(int id)
        {
            var funcionario = await _context.Funcionarios.FindAsync(id);
            if (funcionario != null)
            {
                _context.Funcionarios.Remove(funcionario);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<Funcionario>> ListarTodosAsync()
        {
            return await _context.Funcionarios.ToListAsync();
        }

        public async Task<Funcionario> PesquisarPorIdAsync(int id)
        {
            return await _context.Funcionarios.FindAsync(id);
        }

        public async Task<Funcionario> PesquisarPorNomeAsync(string nome)
        {
            return await _context.Funcionarios.FindAsync(nome);
        }
    }
}
