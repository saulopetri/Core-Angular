﻿namespace Saulo.Dominio
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public TipoFormaPagamentoEnum Tipo { get; set; }
    }
}
