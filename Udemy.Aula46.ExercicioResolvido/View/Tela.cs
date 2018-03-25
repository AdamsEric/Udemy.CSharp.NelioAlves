using System;
using System.Collections.Generic;
using System.Globalization;
using Udemy.Model;

namespace Udemy.View
{
    class Tela
    {
        public static void MostrarMenu()
        {
            Console.WriteLine("UDEMY SISTEMA DE PEDIDOS\n");
            Console.WriteLine("MENU PRINCIPAL\n");
            Console.WriteLine("1 - Listar produtos ordenadamente");
            Console.WriteLine("2 - Cadastrar produtos");
            Console.WriteLine("3 - Cadastrar pedido");
            Console.WriteLine("4 - Mostrar dados de um pedido");
            Console.WriteLine("5 - Sair");
            Console.WriteLine();
            Console.Write("Digite uma opção: ");
        }

        public static void MostrarProdutos()
        {
            Console.Clear();
            Console.WriteLine("UDEMY SISTEMA DE PEDIDOS\n");
            Console.WriteLine("LISTAGEM DE PRODUTOS\n");
            
            for (int i = 0; i < Program.produtos.Count; i++)
            {
                Console.WriteLine(Program.produtos[i]);
            }

            Console.WriteLine();
            Console.Write("Digite qualquer tecla para voltar...");
        }

        public static void CadastrarProduto()
        {
            Console.Clear();
            Console.WriteLine("UDEMY SISTEMA DE PEDIDOS\n");
            Console.WriteLine("NOVO PRODUTO\n");
            Console.WriteLine("Digite os dados do produto:\n");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto novoProduto = new Produto(codigo, descricao, preco);
            Program.produtos.Add(novoProduto);
            Program.produtos.Sort();

            Console.Write("\nProduto cadastrado com sucesso.\nDigite qualquer tecla para voltar...");
        }

        public static void CadastrarPedido()
        {
            Console.Clear();
            Console.WriteLine("UDEMY SISTEMA DE PEDIDOS\n");
            Console.WriteLine("CADASTRAR PEDIDOS\n");
            Console.WriteLine("Digite os dados do pedido:\n");
            Console.Write("Código: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.Write("Dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Mês: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            Pedido pedido = new Pedido(codigo, dia, mes, ano);

            Console.Write("\nQuantos itens tem o pedido? ");
            int totalItens = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalItens; i++)
            {
                Console.WriteLine("\nDigite os dados do " + (i+1) + "º item: ");
                Console.Write("Produto (código): ");
                int codProduto = int.Parse(Console.ReadLine());
                int posProduto = Program.produtos.FindIndex(x => x.Codigo == codProduto);
                if (posProduto == -1)
                {
                    throw new ModelException("Código de produto não encontrado: " + codProduto);
                }
                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());
                Console.Write("Porcentagem de desconto: ");
                double porcentagemDesconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                ItemPedido itemPedido = new ItemPedido(quantidade, porcentagemDesconto, Program.produtos[posProduto], pedido);
                pedido.ItensPedido.Add(itemPedido);
            }
            Program.pedidos.Add(pedido);

            Console.Write("\nPedido cadastrado com sucesso.\nDigite qualquer tecla para voltar...");
        }

        public static void DadosPedido()
        {
            Console.Clear();
            Console.WriteLine("UDEMY SISTEMA DE PEDIDOS\n");
            Console.WriteLine("DADOS DO PEDIDO\n");
            Console.Write("Digite o código do pedido: ");
            int codPedido = int.Parse(Console.ReadLine());
            int posPedido = Program.pedidos.FindIndex(x => x.Codigo == codPedido);
            if (posPedido == -1)
            {
                throw new ModelException("Código de pedido não encontrado: " + codPedido);
            }
            Console.WriteLine();
            Console.WriteLine(Program.pedidos[posPedido]);
            Console.Write("\nDigite qualquer tecla para voltar...");
        }
    }
}
