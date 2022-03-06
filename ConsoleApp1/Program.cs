using System;

namespace ConsoleApp1
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            int numeroExercicio = -1;

            while (numeroExercicio != 0)
            {
                Console.Clear();
                Console.Write("Digite o numero do exercicio (1 a 20, 0 = sair): ");
                numeroExercicio = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (numeroExercicio == 1)
                {
                    Exercicio01();
                }
                else if (numeroExercicio == 2)
                {
                    Exercicio02();
                }
                else if (numeroExercicio == 3)
                {
                    Exercicio03();
                }
                else if (numeroExercicio == 4)
                {
                    Exercicio04();
                }
                else if (numeroExercicio == 5)
                {
                    Exercicio05();
                }
                else if (numeroExercicio == 6)
                {
                    Exercicio06();
                }
                else if (numeroExercicio == 7)
                {
                    Exercicio07();
                }
                else if (numeroExercicio == 8)
                {
                    Exercicio08();
                }
                else if (numeroExercicio == 9)
                {
                    Exercicio09();
                }
                else if (numeroExercicio == 10)
                {
                    Exercicio10();
                }
                else if (numeroExercicio == 11)
                {
                    Exercicio11();
                }
                else if (numeroExercicio == 12)
                {
                    Exercicio12();
                }
                else if (numeroExercicio == 13)
                {
                    Exercicio13();
                }
                else if (numeroExercicio == 14)
                {
                    Exercicio14();
                }
                else if (numeroExercicio == 15)
                {
                    Exercicio15();
                }
                else if (numeroExercicio == 16)
                {
                    Exercicio16();
                }
                else if (numeroExercicio == 17)
                {
                    Exercicio17();
                }
                else if (numeroExercicio == 18)
                {
                    Exercicio18();
                }
                else if (numeroExercicio == 19)
                {
                    Exercicio19();
                }
                else if (numeroExercicio == 20)
                {
                    Exercicio20();
                }
                else
                {
                    Console.WriteLine("Opção invalida");
                    Console.ReadKey();
                }

            }

        }
    }
}
