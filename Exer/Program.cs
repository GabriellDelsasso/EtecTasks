using System;

namespace Exer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            inicio:
                Console.Clear();

                Console.WriteLine("\tEscolha um exercíco para ser executado digitando seu número correspondente.\n");
                for (int i = 1; i <= 9; i++)
                {
                    Console.WriteLine(i + "-Exercício " + i);
                }
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Exercicio1();
                        break;
                    case "2":
                        Exercicio2();
                        break;
                    case "3":
                        Exercicio3();
                        break;
                    case "4":
                        Exercicio4();
                        break;
                    case "5":
                        Exercicio5();
                        break;
                    case "6":
                        Exercicio6();
                        break;
                    case "7":
                        Exercicio7();
                        break;
                    case "8":
                        Exercicio8();
                        break;
                    case "9":
                        Exercicio9();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

            escolha:

                Console.WriteLine("\nDeseja escolher outro exercício para ser executado? \nS-sim \nN-não");
                char escexer = char.Parse(Console.ReadLine());
                if (escexer == 's' || escexer == 'S')
                {
                    goto inicio;
                }
                else if (escexer == 'n' || escexer == 'N')
                {

                }
                else
                {
                    Console.WriteLine("Escolha uma das opções informadas");
                    goto escolha;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exceção: " + e.Message);
            }
        }
        private static Exercicio1 Exercicio1()
        {
            var resultado = Exer.Exercicio1.MetodoExercicio1();

            return resultado;
        }
        private static Exercicio2 Exercicio2()
        {
            var resultado = Exer.Exercicio2.MetodoExercicio2();

            return resultado;
        }
        private static Exercicio3 Exercicio3()
        {
            var resultado = Exer.Exercicio3.MetodoExercicio3();

            return resultado;
        }
        private static Exercicio4 Exercicio4()
        {
            var resultado = Exer.Exercicio4.MetodoExercicio4();

            return resultado;
        }
        private static Exercicio5 Exercicio5()
        {
            var resultado = Exer.Exercicio5.MetodoExercicio5();

            return resultado;
        }
        private static Exercicio6 Exercicio6()
        {
            var resultado = Exer.Exercicio6.MetodoExercicio6();

            return resultado;
        }
        private static Exercicio7 Exercicio7()
        {
            var resultado = Exer.Exercicio7.MetodoExercicio7();

            return resultado;
        }
        private static Exercicio8 Exercicio8()
        {
            var resultado = Exer.Exercicio8.MetodoExercicio8();

            return resultado;
        }
        private static Exercicio9 Exercicio9()
        {
            var resultado = Exer.Exercicio9.MetodoExercicio9();

            return resultado;
        }
    }
}
