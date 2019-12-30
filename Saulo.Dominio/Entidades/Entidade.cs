using System.Collections.Generic;
using System.Linq;

namespace Saulo.Dominio
{
    public abstract class Entidade
    {
        private List<string> _mensagemValidacao;

        public int Id { get; set; }

        public List<string> MensagemValidacao
        {
            get
            {
                if (_mensagemValidacao == null) _mensagemValidacao = new List<string>(); return _mensagemValidacao;
            }
        }

        public abstract void Validar();

        protected bool Valido
        {
            get { return !MensagemValidacao.Any(); }
        }
        protected void LimparMensagensValidacao()
        {
            MensagemValidacao.Clear();
        }
        protected void AdicionarCritica(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }
    }
}
