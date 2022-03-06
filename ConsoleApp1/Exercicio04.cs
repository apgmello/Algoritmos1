using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio04()
        {
            string nomeAluno;
            int nota01, nota02, nota03;
            Console.WriteLine("Crie um algoritmo que leia o nome de um aluno e as notas das três provas que\n" +
                "ele obteve no semestre, com pesos 2, 4 e 6. No final, deve - se informar o nome\n" +
                "do aluno e a sua média ponderada.\n");
            Console.Write("Digite o nome do aluno: ");
            nomeAluno = Console.ReadLine();
            Console.Write("Digite nota da primeira prova: ");
            nota01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a nota da segunda prova: ");
            nota02 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a nota da terceira prova: ");
            nota03 = Convert.ToInt32(Console.ReadLine());
            if (nota01 + nota02 + nota03 == 0)
            {
                Console.WriteLine("Aluno" + nomeAluno + " zerado");
            }
            else
            {
                Console.Write("A média do aluno " + nomeAluno + " é: ");
                Console.WriteLine(((nota01 * 2) + (nota02 * 4) + (nota03 * 6)) / 12);
            }
            Console.ReadKey();
        }
    }
}

