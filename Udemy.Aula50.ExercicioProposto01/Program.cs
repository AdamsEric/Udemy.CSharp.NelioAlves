using System;
using System.Collections.Generic;
using Udemy.Model;
using Udemy.View;

namespace Udemy
{
    class Program
    {
        public static List<Artista> artistas = new List<Artista>();
        public static List<Filme> filmes = new List<Filme>();

        static void Main(string[] args)
        {
            artistas.Add(new Artista(101, "Scarlett Johansson", 4000000.00));
            artistas.Add(new Artista(102, "Chris Evans", 2500000.00));
            artistas.Add(new Artista(103, "Robert Downey Jr.", 3000000.00));
            artistas.Add(new Artista(104, "Morgan Freeman", 4000000.00));
            artistas.Sort();

            int opcao = 0;

            while (opcao != 5)
            {
                Tela.MostrarMenu();
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro inesperado: " + e.Message);
                    opcao = 0;
                }

                switch (opcao)
                {
                    case 1:
                        Tela.ListarArtistas();
                        break;
                    case 2:
                        try
                        {
                            Tela.CadastrarArtista();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }
                        break;
                    case 3:
                        try
                        {
                            Tela.CadastrarFilme();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }
                        break;
                    case 4:
                        try
                        {
                            Tela.DadosFilme();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Erro inesperado: " + e.Message);
                        }
                        break;
                    case 5:
                        Tela.Sair();
                        break;
                    default:
                        Console.WriteLine();
                        Console.Write("Opção inválida.");
                        break;
                }
                Console.WriteLine();
                Console.Write("Pressione qualquer tecla para voltar...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
