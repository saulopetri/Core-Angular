using System;

namespace Saulo.Dominio
{
    public class Produto: Entidade
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validar()
        {
            if (String.IsNullOrEmpty(Nome))
                AdicionarCritica("Nome do produto não informado");
        }
    }
}
