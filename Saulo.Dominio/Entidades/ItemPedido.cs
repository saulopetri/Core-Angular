namespace Saulo.Dominio
{
    public class ItemPedido : Entidade
    {
        public int PedidoId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }

        public override void Validar()
        {
            LimparMensagensValidacao();

            if (ProdutoId == 0)
                AdicionarCritica("Produto não informado");

            if (Quantidade == 0)
                AdicionarCritica("Quantidade não informada");
        }
    }
}
