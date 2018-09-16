namespace Udemy.Secao07.Aula114.Arquivos
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Dev\Udemy.CSharp.NelioAlves\Udemy.Secao07.Aula114.Directory\My Folder";

            try
            {
                // Listar todos os diretórios dentro da pasta
                IEnumerable<string> folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders:");
                folder.ToList().ForEach(e => Console.WriteLine(e));

                Console.WriteLine();
                // Listar todos os diretórios dentro da pasta
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files:");
                files.ToList().ForEach(e => Console.WriteLine(e));

                // Criar uma nova pasta
                Directory.CreateDirectory(path + @"\Nova Pasta");

                /*
                // Exemplos com DirectoryInfo

                DirectoryInfo directoryInfo = new DirectoryInfo(path);

                // Listar todos os diretórios dentro da pasta
                var folder2 = directoryInfo.EnumerateDirectories("*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders:");
                folder2.ToList().ForEach(e => Console.WriteLine(directoryInfo.FullName + @"\{0}", e));

                Console.WriteLine();
                // Listar todos os diretórios dentro da pasta
                var files2 = directoryInfo.EnumerateFiles("*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files:");
                files2.ToList().ForEach(e => Console.WriteLine(directoryInfo.FullName + @"\{0}", e));

                // Criar uma nova pasta
                directoryInfo.CreateSubdirectory("Novíssima Pasta");
                 */
            }
            catch (IOException ioex)
            {
                Console.WriteLine("Um erro ocorreu: ", ioex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
