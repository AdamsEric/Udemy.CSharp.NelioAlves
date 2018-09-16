namespace Udemy.Secao07.Aula113.Arquivos
{
    using System;
    using System.IO;
    
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:/Dev/Udemy.CSharp.NelioAlves/Udemy.Secao07.Aula113.StreamWriter/Origem/Arquivo1.txt";
            string targetPath = @"C:/Dev/Udemy.CSharp.NelioAlves/Udemy.Secao07.Aula113.StreamWriter/Destino/Arquivo2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException ioex)
            {
                Console.WriteLine("Ocorreu um erro: {0}", ioex.Message);
            }
            Console.ReadLine(
        }
    }
}
