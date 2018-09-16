namespace Udemy.Aula115.Arquivos
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Dev\Udemy.CSharp.NelioAlves\Udemy.Secao07.Aula115.Path\My Folder\file1.txt";

            try
            {
                Console.WriteLine("Path: {0}", path);
                Console.WriteLine();
                // Obter nome do diretório do arquivo
                Console.WriteLine("GetDirectoryName: {0}", Path.GetDirectoryName(path));
                // Caractere de separação entre diretórios e subdiretórios
                Console.WriteLine("DirectorySeparatorPath: {0}", Path.DirectorySeparatorChar);
                // Caractere de separação entre caminhos distintos
                Console.WriteLine("PathSeparator: {0}", Path.PathSeparator);
                // Obter nomes dos arquivos
                Console.WriteLine("GetFileName: {0}", Path.GetFileName(path));
                // Obter nome do arquivo sem extensão
                Console.WriteLine("GetFileNameWithoutExtension: {0}", Path.GetFileNameWithoutExtension(path));
                // Obter extensão do arquivo
                Console.WriteLine("GetExtension: {0}", Path.GetExtension(path));
                // Obter caminho completo do arquivo
                Console.WriteLine("GetFullPath: {0}", Path.GetFullPath(path));
                // Obtem o caminho da pasta temporária do sistema
                Console.WriteLine("GetTempPath: {0}", Path.GetTempPath());
            }
            catch (IOException ioex)
            {
                Console.WriteLine("Um erro ocorreu: {0}", ioex.Message);
            }
            catch (ArgumentException aex)
            {
                Console.WriteLine("Entrada inválida: {0}", aex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
