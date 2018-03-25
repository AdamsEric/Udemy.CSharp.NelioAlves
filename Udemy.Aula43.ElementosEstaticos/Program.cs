using System;
using System.Collections.Generic;
using System.Globalization;

namespace Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x, y, z;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());

            int resultado = Util.MenorDeTres(x, y, z);

            Console.WriteLine("MENOR = " + resultado);
            */

            int n;
            List<Figura> lista = new List<Figura>();
            char figura = ' ';

            Console.Write("Quantas figuras você vai digitar? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                while (figura != 't' && figura != 'r' && figura != 'q')
                {
                    Console.Write("Figura " + (i + 1) + " - triângulo ou retângulo (t/r/q)? ");
                    figura = char.Parse(Console.ReadLine());
                    if (figura == 'r')
                    {
                        Figura f = Tela.LerRetangulo();
                        lista.Add(f);
                    }
                    else if (figura == 't')
                    {
                        Figura f = Tela.LerTriangulo();
                        lista.Add(f);
                    }
                    else if (figura == 'q')
                    {
                        
                        Figura f = Tela.LerQuadrado();
                        lista.Add(f);
                    }
                }
                figura = ' ';
            }

            Console.WriteLine("\nÁrea das figuras: ");

            for (int i = 0; i < n; i++)
            {
                {
                    Console.WriteLine("Figura " + (i + 1) + ": " + lista[i].Area().ToString("F1", CultureInfo.InvariantCulture));
                }
            }

            Console.ReadLine();
        }
    }
}
