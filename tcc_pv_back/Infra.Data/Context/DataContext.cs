

using domain.Entity;
using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Context
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Produto> Produto {get; set;}
        public DbSet<entradaProduto> entradaProduto {get; set;} 

    }
}