using System;
using System.Collections.Generic;
using System.Text;

namespace Saulo.Dominio.Entidades
{
    public class ItemPedido : Entidade
    {
        public int PedidoId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
    }
}
