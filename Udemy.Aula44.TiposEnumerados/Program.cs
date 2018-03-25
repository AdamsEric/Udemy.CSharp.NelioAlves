using System;

namespace Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            MesEnum mes = MesEnum.Janeiro;
            int valorMes = (int) MesEnum.Março;

            Console.WriteLine(mes);
            Console.WriteLine(valorMes);

            Console.ReadLine();

        }
    }
}
