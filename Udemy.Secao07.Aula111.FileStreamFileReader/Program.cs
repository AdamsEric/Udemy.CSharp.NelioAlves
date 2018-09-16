using System;
using System.IO;

namespace Udemy.Secao07.Aula111.Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:/Dev/Udemy.CSharp.NelioAlves/Udemy.Secao07.Aula111.FileStreamFileReader/Temp/Arquivo1.txt";

            /*
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
                Console.ReadLine();
            }
            catch (IOException ioex)
            {  
                Console.WriteLine("Um erro ocorreu: {0}", ioex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }

                if (fs != null)
                {
                    fs.Close();
                }
            }
            */

            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);
                // string line = sr.ReadLine();
                // Console.WriteLine(line);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException ioex)
            {
                Console.WriteLine("Um erro ocorreu: {0}", ioex.Message);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
            Console.ReadLine();
        }
    }
}
