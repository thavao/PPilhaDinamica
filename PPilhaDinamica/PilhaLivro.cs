using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPilhaDinamica
{
    internal class PilhaLivro
    {
        Livro topo;
        public PilhaLivro()
        {
            topo = null;
        }
        bool Vazia()
        {
            if (topo == null)
                return true;

            return false;
        }
        public void Push(Livro aux)
        {
            if (Vazia())
            {
                topo = aux;
            }
            else
            {
                aux.setAnterior(topo);
                topo = aux;
            }
        }
        public void Print()
        {
            Livro aux = topo;
            if (Vazia())
            {
                Console.WriteLine("Pilha vaiza!");
            }
            else
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.getAnterior();
                } while (aux != null);
                Console.WriteLine("Fim da impressão");
            }
        }

        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("Pilha vazia!");
            }
            else
            {
                do
                {
                    Console.WriteLine(topo.ToString());
                    topo = topo.getAnterior();
                } while (topo != null);
            }
        }

        public void Buscar(string t)
        {
            if (!Vazia())
            {
                Livro aux = topo;
                bool encontrou = false;
                do
                {
                    if (t.Equals(aux.getTitulo()))
                    {
                        Console.WriteLine("Livro encontrado!");
                        Console.WriteLine(aux.ToString());
                        encontrou = true;
                    }
                    aux = aux.getAnterior();
                } while (aux != null);
                if (!encontrou)
                {
                    Console.WriteLine("Livro não encontrado...");
                }
            }
            else
            {
                Console.WriteLine("Pilha vazia!");
            }
        }
    }
}
