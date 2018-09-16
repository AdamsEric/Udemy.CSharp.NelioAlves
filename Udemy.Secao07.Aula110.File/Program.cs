using System;
using System.IO;
using System.Linq;

namespace Udemy.Secao07.Aula110.Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Dev\Udemy.CSharp.NelioAlves\Udemy.Secao07.Aula110.File\Origem\Arquivo1.txt";
            string targetPath = @"C:\Dev\Udemy.CSharp.NelioAlves\Udemy.Secao07.Aula110.File\Destino\Arquivo2.txt";

            try
            {
                FileInfo fileinfo = new FileInfo(sourcePath);

                if ((new FileInfo(targetPath)).Directory.GetFiles().Length == 0)
                {
                    fileinfo.CopyTo(targetPath);
                    Console.WriteLine("Arquivo copiado com sucesso!");
                }
                string[] lines = File.ReadAllLines(sourcePath);
                lines.OrderBy(e => e).ToList().ForEach(e => Console.WriteLine(e));
                Console.ReadLine();
            }
            catch (IOException ioex)
            {
                Console.WriteLine("Um erro ocorreu: {0}", ioex.Message);
                Console.ReadLine();
            }
        }
    }
}
