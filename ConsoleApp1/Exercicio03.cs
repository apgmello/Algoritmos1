using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio03()
        {
            string nomeVendedor;
            double salarioFixo, totalVendas, comissao;
            Console.WriteLine("Elabore um algoritmo que leia o nome de um vendedor, o seu salário fixo e o\n" +
                "total de vendas efetuadas por ele no mês(em dinheiro).Sabendo que esse\n" +
                "vendedor ganha 20 % de comissão sobre suas vendas efetuadas, faça que o\n" +
                "algoritmo informe o seu nome, o salário fixo e salário no final do mês.\n");

            Console.Write("Digite o nome do vendedor: ");
            nomeVendedor = Console.ReadLine();
            Console.Write("Digite o salário do vendedor: R$ ");
            salarioFixo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Total de vendas em dinheiro: R$ ");
            totalVendas = Convert.ToInt32(Console.ReadLine());
            comissao = totalVendas * 0.2;
            if (totalVendas == 0)
            {
                Console.WriteLine("Vendedor " + nomeVendedor + " não possui comissão.");
            }
            else
            {
                Console.Write("A comissão é: R$ ");
                Console.WriteLine(comissao);
            }
            Console.Write("O salário total do vendedor " + nomeVendedor + " é: R$ ");
            Console.WriteLine(salarioFixo + comissao);
            Console.ReadKey();
        }

    }
}