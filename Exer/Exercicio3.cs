using System;
using System.Collections.Generic;
using System.Text;

namespace Exer
{
    public class Exercicio3
    {
        public static Exercicio3 MetodoExercicio3()
        {
            try
            {
                float num1, num2, resultado = 0;
                char escolha;

            inicio:
                Console.Clear();

                Console.WriteLine("\tEx - 3 Desenvolva uma calculadora, onde será necessário entrar com a operação, \n\tprimeiro e segundo valor, exiba o resultado na tela.\n");
                Console.WriteLine("Escolha a operação digitando o número correspondente");
                Console.WriteLine("1 - Adição (+) \n2 - Subtração (-) \n3 - Multiplicação (*) \n4 - Divisão (/)");
                var operação = Console.ReadLine();

                if (4 < int.Parse(operação))
                {
                    Console.WriteLine("\nO número escolhido não corresponde a nenhuma operação");
                    goto fim;
                }
                Console.Write("\nInforme o primeiro número: ");
                num1 = float.Parse(Console.ReadLine());

                Console.Write("Informe o segundo número: ");
                num2 = float.Parse(Console.ReadLine());

                switch (operação)
                {
                    case "1":
                        resultado = num1 + num2;
                        break;
                    case "2":
                        resultado = num1 - num2;
                        break;
                    case "3":
                        resultado = num1 * num2;
                        break;
                    case "4":
                        resultado = num1 / num2;
                        break;
                    default:
                        break;
                }
                if (int.Parse(operação) == 1)
                {
                    Console.WriteLine("\nO resultado é: {0} + {1} = {2}", num1, num2, resultado);
                }
                else if (int.Parse(operação) == 2)
                {
                    Console.WriteLine("\nO resultado é: {0} - {1} = {2}", num1, num2, resultado);
                }
                else if (int.Parse(operação) == 3)
                {
                    Console.WriteLine("\nO resultado é: {0} * {1} = {2}", num1, num2, resultado);
                }
                else
                {
                    Console.WriteLine("\nO resultado é: {0} / {1} = {2}", num1, num2, resultado);
                }
            fim:

                Console.WriteLine("\nDeseja realizar outra operação? \nS-sim \nN-Não");
                escolha = char.Parse(Console.ReadLine());
                if (escolha == 's' || escolha == 'S')
                {
                    goto inicio;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Digite apenas números");
            }

            var retorno = new Exercicio3();
            return retorno;
        }
    }
}
