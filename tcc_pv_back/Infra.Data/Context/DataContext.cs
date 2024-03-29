using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Infra.Data.Context
{
    public class DataContext : DbContext
    {
        
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Produto> Produto { get; set; }

        public DbSet<entradaProduto> entradaProduto { get; set; }

        public DbSet<saidaProduto> saidaProduto { get; set; }

        public DbSet<tabelaCaixa> tabelaCaixa { get; set; }

        public DbSet<tabelaContaCapital> tabelaContaCapital { get; set; }

        public DbSet<tabelaContaCorrente> tabelaContaCorrente { get; set; }

        public DbSet<tabelaEmendaImpositiva> tabelaEmendaImpositiva { get; set; }

        public DbSet<tabelaEmendaParlamentar> tabelaEmendaParlamentar { get; set; }

        public DbSet<tabelaVerbaEstadual> tabelaVerbaEstadual { get; set; }

        public DbSet<tabelaVerbaMunicipal> tabelaVerbaMunicipal { get; set; }

        public DbSet<tabelaResidente> tabelaResidente { get; set; }

        public DbSet<tabelaQuarto> tabelaQuarto { get; set; }

        public DbSet<tabelaDoador> tabelaDoador { get; set; }

        public DbSet<tabelaFornecedor> tabelaFornecedor { get; set; }
    }
}
