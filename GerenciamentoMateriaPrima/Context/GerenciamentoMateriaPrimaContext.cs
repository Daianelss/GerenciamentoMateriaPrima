using GerenciamentoMateriaPrima.Model;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoMateriaPrima.Context
{
    public class GerenciamentoMateriaPrimaContext : DbContext
    {

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<TipoMateriaPrima> TipoMateriaPrimas { get; set; }
        public DbSet<MovimentoMateriaPrima> MovimentoMateriaPrimas { get; set; }
        public DbSet<TipoProcesso> TipoProcessos { get; set; }
        public DbSet<Movimento> Movimentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = $@"Data Source=banco_gerenciamento.db";
            optionsBuilder
                .UseSqlite(connection)
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
    }
}
