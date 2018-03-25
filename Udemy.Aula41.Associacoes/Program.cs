using System;

namespace Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Fornecedor f;
            Produto p;

            f = new Fornecedor("Lojas Ltda", "lojas@gmail.com", "3273-3873");
            p = new Produto("TV", 1000.00, f);

            Console.WriteLine(p);

            Console.ReadLine();
        }
    }
}
