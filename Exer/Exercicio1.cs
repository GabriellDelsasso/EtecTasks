using System;
using System.Collections.Generic;
using System.Text;

namespace Exer
{
    public class Exercicio1
    {
        public static Exercicio1 MetodoExercicio1()
        {
            Console.Clear();
            try
            {
                float num, num2;
                do
                {
                    Console.WriteLine("\tEX - 1  Desenvolva um algoritmo que solicite a entrada de um número e calcule se o número é par ou impar.\n");
                    Console.Write("Insira um número: ");
                    num = float.Parse(Console.ReadLine());

                    if (num % 2 == 0)
                    {
                        Console.WriteLine("\nO número informado é par");
                    }
                    else
                    {
                        Console.WriteLine("\nO número informado é impar");
                    }
                    Console.WriteLine("\nDigite 1 para executar novamente \nDigite 2 para sair");
                    num2 = float.Parse(Console.ReadLine());

                } while (num2 != 2);
            }
            catch (FormatException)
            {
                Console.WriteLine("Digite apenas números");
            }

            var retorno = new Exercicio1();
            return retorno;
        }
    }
}
