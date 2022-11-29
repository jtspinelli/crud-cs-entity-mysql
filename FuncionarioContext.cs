using System.Linq;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore;

namespace CRUDFuncionarios
{
    internal class FuncionarioContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(ConnectionStringBuilder.GetConnectionString());
        }
    }
}
