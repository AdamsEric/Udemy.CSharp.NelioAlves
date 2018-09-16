namespace Udemy.Secao07.Aula112.Arquivos
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:/Dev/Udemy.CSharp.NelioAlves/Udemy.Secao07.Aula112.BlocoUsing/Temp/Arquivo1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException ioex)
            {
                Console.WriteLine("Ocorreu um erro {0}", ioex.Message);
            }
            Console.ReadLine();
        }
    }
}
