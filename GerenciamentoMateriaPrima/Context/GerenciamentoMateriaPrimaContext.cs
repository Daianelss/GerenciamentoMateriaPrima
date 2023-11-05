using GerenciamentoMateriaPrima.Model;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace GerenciamentoMateriaPrima.Context
{
    public class GerenciamentoMateriaPrimaContext : DbContext   
    {

        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = ConfigurationManager.AppSettings["Conexao"];
            var version = new MySqlServerVersion(new Version(8, 0, 33));
            optionsBuilder.UseMySql(connection, version);
        }
    }
}
