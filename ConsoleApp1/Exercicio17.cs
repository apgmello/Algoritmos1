using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        public static void Exercicio17()
        {
            string nomeAluno;
            int nota01, nota02, nota03, nota04, mediaAluno;
            Console.WriteLine("Efetue a leitura de quatro valores reais referentes a quatro notas escolares de\n" +
                "um aluno e apresente mensagem informando que o aluno está aprovado caso o\n" +
                "valor da média escolar seja maior ou igual a 5. Caso o aluno não seja aprovado,\n" +
                "apresente mensagem informando que o aluno encontra - se reprovado.Ao final,\n" +
                "além das mensagens, apresente o valor da média do aluno.\n");

            Console.Write("Nome do Aluno: ");
            nomeAluno = Console.ReadLine();
            Console.Write("Nota da primeira avaliação: ");
            nota01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nota da segunda avaliação: ");
            nota02 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nota da terceira avaliação: ");
            nota03 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nota da quarta avaliação: ");
            nota04 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Média final do aluno " + nomeAluno + ": ");
            mediaAluno = ((nota01 + nota02 + nota03 + nota04) / 4);
            Console.WriteLine(mediaAluno);
            if (mediaAluno >= 5)
            {
                Console.WriteLine("Aluno aprovado :D");
            }
            else
            {
                Console.WriteLine("Aluno reprovado :(");
            }
            Console.ReadKey();
        }
    }
}