using System;
using System.Collections.Generic;
using System.Text;

namespace Exer
{
    public class Exercicio6
    {
        public static Exercicio6 MetodoExercicio6()
        {
            try
            {
                char[] letra = new char[200];

            inicio:
                Console.Clear();

                Console.WriteLine("\tEx - 6 Desenvolva um algoritmo que solicite a entrada de uma frase, após isto troque todas as \n\tletras A ou a por &, porém não utilize o método Replace().\n");
                Console.WriteLine("Escreva uma frase:");
                var frase = Console.ReadLine();

                letra = frase.ToLower().ToCharArray();

                for (int i = 0; i < letra.Length; i++)
                {
                    while (letra[i] == 'a')
                    {
                        letra[i] = '&';
                    }
                }
                Console.WriteLine("\nA letra 'A' e 'a' presente no texto foi alterada por '&':");
                Console.WriteLine(letra);

            pergunta:

                Console.WriteLine("\nDeseja digitar um novo texto? \nS-sim \nN-Não");
                var escolha = char.Parse(Console.ReadLine());
                if (escolha == 's' || escolha == 'S')
                {
                    goto inicio;
                }
                else if (escolha == 'n' || escolha == 'N')
                {

                }
                else
                {
                    Console.WriteLine("Digite a letra correspondente a escolha");
                    goto pergunta;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exceção: " + e.Message);
            }

            var retorno = new Exercicio6();
            return retorno;
        }
    }
}
