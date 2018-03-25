using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Udemy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> lista = new List<Funcionario>();
            string cpf, nome, cpf_aumento;
            double salario, percentual_aumento;
            int n, inclusao = 0;

            Console.Write("Quantos funcionários serão cadastrados? ");
            n = int.Parse(Console.ReadLine());

            while (inclusao < n)
            {
                inclusao++;
                Console.WriteLine("Dados do " + inclusao + "º funcionário: ");
                Console.Write("CPF: ");
                cpf = Console.ReadLine();
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("Salario: ");
                salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                if (lista.FindIndex(x => x.CPF == cpf ) != -1)
                {
                    Console.WriteLine();
                    Console.Write("CPF repetido! ");
                    inclusao--;
                } else
                {
                    lista.Add(new Funcionario(cpf, nome, salario));
                }
            }


            Console.Write("Digite o CPF do funcionário que terá aumento: ");
            cpf_aumento = Console.ReadLine();

            int id_cpf = lista.FindIndex(x => x.CPF == cpf_aumento);

            if (id_cpf != -1)
            {
                Console.Write("Digite a porcentagem de aumento: ");
                percentual_aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista[id_cpf].AumentarSalario(percentual_aumento);
            } else
            {
                Console.WriteLine("CPF INEXISTENTE");
                cpf_aumento = "";
            }
            Console.WriteLine("\nLista atualizada de funcionários");
            for (int i = 0; i < lista.Count(); i++)
            {
                Console.WriteLine(lista[i]);
            }
            Console.ReadLine();
        }
    }
}
