using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio07()
        {
            int numeroXerox;
            Console.WriteLine("Escreva um programa que resolva o seguinte problema: uma cópia “xerox”\n" +
                "custa R$ 0, 50 por folha, mas acima de 200 folhas esse valor cai para R$ 0, 30 por\n" +
                "unidade.Dado o total de cópias, informe o valor a ser pago.\n");
            Console.Write("Escreva o numero de cópias: ");
            numeroXerox = Convert.ToInt32(Console.ReadLine());
            if (numeroXerox <= 200)
            {
                Console.Write("Valor a ser pago: ");
                Console.Write(numeroXerox * 0.5);
            }
            else
            {
                Console.Write("Valor a ser pago: ");
                Console.Write(numeroXerox * 0.3);
            }
            Console.ReadKey();
        }
    }
}