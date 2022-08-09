using Microsoft.EntityFramework;

namespace TCC_PV_contexto
{
    public class TccContexto : DbContext
    {
        public DbSet<category> Category{get; set;}
        
    }
}