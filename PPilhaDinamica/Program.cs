namespace PPilhaDinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PilhaLivro minhaPilha = new PilhaLivro();
            int opcao;
            do
            {
                Console.WriteLine("Menu principal - Pilha de Livros");
                Console.WriteLine("Opções:");
                Console.WriteLine("1 - Inserir Livro");
                Console.WriteLine("2 - Remover Livro");
                Console.WriteLine("3 - Imprimir Pilha");
                Console.WriteLine("4 - Buscar Livro na Pilha");
                Console.WriteLine("0 - Sair");
                Console.Write("Informe a opção desejada: < >\b\b");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        minhaPilha.Push(CadastrarLivro());
                        break;
                    case 2:
                        minhaPilha.Pop();
                        break;
                    case 3:
                        minhaPilha.Print();
                        break;
                    case 4:
                        Console.Write("Informe o título do livro que deseja buscar: ");
                        minhaPilha.Buscar(Console.ReadLine());
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida...");
                        break;


                }
                Console.WriteLine("Pressione Enter para continuar...");
                Console.ReadLine();
                Console.Clear();
            } while (opcao != 0);

            static Livro CadastrarLivro()
            {
                string titulo;
                Console.Write("Informe o Título do Novo Livro: ");
                titulo = Console.ReadLine();

                return new Livro(titulo);
            }
        }

    }
}
