using System;
using System.Collections.Generic;
using System.Globalization;

namespace Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            List<Figura> lista = new List<Figura>();
            char figura = ' ';

            Console.Write("Quantas figuras você vai digitar? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                while (figura != 't' && figura != 'r' && figura != 'q') {
                    Console.Write("Figura " + (i+1) + " - triângulo ou retângulo (t/r/q)? ");
                    figura = char.Parse(Console.ReadLine());
                    if (figura == 'r')
                    {
                        Console.Write("Largura: ");
                        double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Altura: ");
                        double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Figura f = new Retangulo(largura, altura);
                        lista.Add(f);
                    }
                    else if (figura == 't')
                    {
                        Console.Write("Lado a: ");
                        double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Lado b: ");
                        double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Console.Write("Lado c: ");
                        double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Figura f = new Triangulo(a, b, c);
                        lista.Add(f);
                    }
                    else if (figura == 'q')
                    {
                        Console.Write("Lado: ");
                        double lado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        Figura f = new Quadrado(lado);
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
