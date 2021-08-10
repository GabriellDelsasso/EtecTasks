using System;
using System.Collections.Generic;
using System.Text;

namespace Exer
{
    public class Exercicio4
    {
        public static Exercicio4 MetodoExercicio4()
        {
            int idade;
            char escolha;

            inicio:
            Console.Clear();

            try
            {
                Console.WriteLine("\tEx - 4 Desenvolva um algoritmo que solicite a entrada da idade de um determinado usuário, \n\tse for menor que 18 anos exiba na cor vermelha “Sem permissão”, caso seja maior ou igual\n\ta 18 anos exiba na cor verde “Permissão concedida”.\n");
                Console.Write("Informe sua idade: ");
                idade = int.Parse(Console.ReadLine());

                if (idade < 18)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sem permissão");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Permissão concedida");
                }
                Console.ResetColor();

                Console.WriteLine("\nDeseja inserir sua idade novamente? \nS-sim \nN-Não");
                escolha = char.Parse(Console.ReadLine());
                if (escolha == 's' || escolha == 'S')
                {
                    goto inicio;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\nDigite apenas números");
            }

            var retorno = new Exercicio4();
            return retorno;
        }
    }
}
