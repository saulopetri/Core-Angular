using Saulo.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Saulo.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int UsuarioId { get; set; }
        public int FormaPagamentoId { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public DateTime DataPedido { get; set; }

        /// <summary>
        /// Deve ter pelo menos um item ou muitos itens
        /// </summary>
        public ICollection<ItemPedido> Itens { get; set; }
    }
}
