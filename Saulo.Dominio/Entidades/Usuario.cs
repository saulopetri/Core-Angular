using System;
using System.Collections.Generic;

namespace Saulo.Dominio
{
    public class Usuario : Entidade
    {
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        /// <summary>
        /// Usuario pode der nenhum ou muitos pedidos
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validar()
        {
            if (String.IsNullOrEmpty(Nome))
                AdicionarCritica("Nome do usuário  não informado");

            if (String.IsNullOrEmpty(SobreNome))
                AdicionarCritica("SobreNome do usuário  não informado");

            if (String.IsNullOrEmpty(Email))
                AdicionarCritica("Email do usuário não informado");
        }
    }
}
