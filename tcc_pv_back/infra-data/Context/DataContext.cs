
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using domain;
using Microsoft.EntityFrameworkCore;


namespace infra_data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<contaspagar> contasapagar { get; set; }

        public DbSet<contasreceber> contasreceber{get; set;}

        public DbSet<Compras> Compras{get; set;}

        public DbSet<Doador> Doador{get; set;}

        public DbSet<fornecedor> fornecedor{get; set;}

         public DbSet<funcionario> funcionario{get; set;}

        public DbSet<produto> produto{get; set;}

         public DbSet<quartos> quartos{get; set;}

          public DbSet<residente> residente{get; set;}

    }
}