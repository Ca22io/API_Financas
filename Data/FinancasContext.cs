using Microsoft.EntityFrameworkCore;
using API_Financas.Models;

namespace API_Financas.Data
{
    public class FinancasContext : DbContext
    {
        public FinancasContext(DbContextOptions<FinancasContext> options) : base(options)
        {
        }

        public DbSet<TipoModel> Tipos { get; set; }

        public DbSet<CategoriaModel> Categorias { get; set; }

        public DbSet<TransacaoModel> Transacoes { get; set; }


    }
}