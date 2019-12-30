using Microsoft.EntityFrameworkCore;
using Saulo.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Saulo.Repositorio.Contexto
{
    public class SauloContexto : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<ItemPedido> ItemPedido { get; set; }
        public DbSet<FormaPagamento> FormaPagamento { get; set; }
    }
}
