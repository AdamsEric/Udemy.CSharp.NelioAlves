using System;
using System.Globalization;
using Udemy.Model;

namespace Udemy.View
{
    class Tela
    {
        public static void Cabecalho(int Menu)
        {
            Console.Clear();
            Console.WriteLine("UDEMY CINEMA");
            Console.WriteLine();
            switch (Menu)
            {
                case 1:
                    Console.WriteLine("LISTA DE ARTISTAS");
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine("NOVO ARTISTA");
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine("NOVO FILME");
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine("DADOS DOS FILMES");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("MENU PRINCIPAL");
                    Console.WriteLine();
                    break;
            }
        }

        public static void MostrarMenu()
        {
            Cabecalho(0);
            Console.WriteLine("1 - Listar artistas ordenadamente");
            Console.WriteLine("2 - Cadastrar artista");
            Console.WriteLine("3 - Cadastrar filme");
            Console.WriteLine("4 - Mostrar dados de um filme");
            Console.WriteLine("5 - Sair");
            Console.WriteLine();
            Console.Write("Entre com a opção desejada: ");
        }

        public static void ListarArtistas()
        {
            Cabecalho(1);
            for (int i = 0; i < Program.artistas.Count; i++){
                Console.WriteLine(Program.artistas[i]);
            }
        }

        public static void CadastrarArtista()
        {
            Cabecalho(2);
            Console.WriteLine("Digite os dados do artista:");
            Console.Write("Código: ");
            int codArtista = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Valor do cachê: ");
            double cache = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Artista A = new Artista(codArtista, nome, cache);

            Program.artistas.Add(A);
            Program.artistas.Sort();
        }

        public static void CadastrarFilme()
        {
            Cabecalho(3);
            Console.WriteLine("Digite os dados do filme:");
            Console.Write("Código: ");
            int codFilme = int.Parse(Console.ReadLine());
            Console.Write("Título: ");
            string titulo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            Filme F = new Filme(codFilme, titulo, ano);

            Console.WriteLine();
            Console.Write("Quantas participações tem o filme? ");
            int qtdeParticipacoes = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtdeParticipacoes; i++)
            {
                Console.WriteLine("Digite os dados da " + (i + 1) + "º participação: ");
                Console.Write("Artista (código): ");
                int codArtista = int.Parse(Console.ReadLine());
                int posArtista = Program.artistas.FindIndex(x => x.Codigo == codArtista);

                if (posArtista == -1)
                {
                    throw new ModelException("Código do artista não encontrado");
                }

                Console.Write("Desconto: ");
                double desconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Participacao P = new Participacao(Program.artistas[posArtista], F, desconto);
                F.Participacoes.Add(P);
            }
            Program.filmes.Add(F);
        }

        public static void DadosFilme()
        {
            Cabecalho(4);
            Console.Write("Digite o código do filme: ");
            int codFilme = int.Parse(Console.ReadLine());
            int posFilme = Program.filmes.FindIndex(x => x.Codigo == codFilme);

            if (posFilme == -1)
            {
                throw new ModelException("Código do filme não encontrado");
            }

            Console.WriteLine(Program.filmes[posFilme]);
        }

        public static void Sair()
        {
            Console.WriteLine();
            Console.Write("Fim do programa.");
        }
    }
}
