using BlazorVendasBCCTN.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorVendasBCCTN.Data.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}
