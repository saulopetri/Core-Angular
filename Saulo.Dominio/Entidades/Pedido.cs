using System;
using System.Collections.Generic;
using System.Linq;

namespace Saulo.Dominio
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

        public override void Validar()
        {
            LimparMensagensValidacao();
            
            if (!Itens.Any())
                AdicionarCritica("Crítica - Pedido deve ter pelo menos um item ou muitos itens");
        }
    }
}
