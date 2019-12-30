using Saulo.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace Saulo.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public TipoFormaPagamentoEnum Tipo { get; set; }
    }
}
