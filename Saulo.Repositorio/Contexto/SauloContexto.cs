using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Saulo.Dominio;
using Saulo.Repositorio.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace Saulo.Repositorio
{
    public class SauloContexto : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<ItemPedido> ItemPedido { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }

        public SauloContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
