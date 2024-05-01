using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPilhaDinamica
{
    internal class Livro
    {
        string titulo;
        Livro anterior;
        public Livro(string titulo)
        {
            this.titulo = titulo;
            anterior = null;
        }

        public override string? ToString()
        {
            return "Titulo: " + titulo;
        }

        public void setAnterior(Livro aux)
        {
            anterior = aux;
        }
        public Livro getAnterior()
        {
            return anterior;
        }
        public string getTitulo()
        {
            return titulo;
        }
    }
}
