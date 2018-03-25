using System;
using System.Collections.Generic;

namespace Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("João");
            lista.Add("Maria");
            lista.Add("Ana");
            lista.Add("José");

            for(int i=0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.WriteLine();
            lista.Remove("Maria");
            

            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            Console.ReadLine();
        }
    }
}
