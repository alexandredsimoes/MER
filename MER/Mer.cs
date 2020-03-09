using MER.Libs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MER
{
    public class MerContext : DbContext
    {
        public DbSet<Beneficiario> Beneficiarios { get; set; }
        public DbSet<Loja> Lojas { get; set; }        
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=MER;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Beneficiario>().HasKey("clienteCodigo");
            modelBuilder.Entity<Loja>().HasKey("lojaCodigo");
            modelBuilder.Entity<Venda>().HasKey("codigoVenda");
            modelBuilder.Entity<Item>().HasKey("itemId");
            modelBuilder.Entity<Item>().HasOne(x => x.produto);
            modelBuilder.Entity<Produto>().HasKey("skuCodigo");
            
        }
    }
}
