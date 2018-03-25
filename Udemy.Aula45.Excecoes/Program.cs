using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Nome do titular: ");
            string titular = Console.ReadLine();
            Console.Write("Limite de saque: ");
            double limite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Conta c = new Conta(numero, titular, limite);

            Console.Write("\nInforme um valor para deposito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Depositar(valorDeposito);
            Console.WriteLine("Novo Saldo = R$ " + c.Saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.Write("\nInforme um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            try
            {
                c.Sacar(valorSaque);
                Console.WriteLine("Novo Saldo = R$ " + c.Saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (OperacaoException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
