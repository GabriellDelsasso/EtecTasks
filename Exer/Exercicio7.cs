using System;
using System.Collections.Generic;
using System.Text;

namespace Exer
{
    public class Exercicio7
    {
        public static Exercicio7 MetodoExercicio7()
        {
            float salario, rsalario;

            inicio:
            Console.Clear();

            try
            {
                Console.WriteLine("\tEx - 7 Desenvolva um algoritmo que calcule o reajuste salarial. Se o salário for abaixo de \n\t1.700 o ajuste é de R$300.00, se maior de R$ 200.00. Para finalizar, exiba o novo salário na tela.\n");
                Console.Write("Digite o valor do salário para que seja realizado o reajuste: R$");
                salario = float.Parse(Console.ReadLine());

                if (salario < 1700)
                {
                    rsalario = salario + 300;
                }
                else
                {
                    rsalario = salario + 200;
                }
                Console.Write("\nValor informado: R${0} Valor com reajuste: R${1}", salario, rsalario);

                Console.WriteLine("\nDeseja realizar outro reajuste salarial? \nS-sim \nN-não");
                char escolha = char.Parse(Console.ReadLine());
                if (escolha == 's' || escolha == 'S')
                {
                    goto inicio;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nDigite apenas números");
            }

            var retorno = new Exercicio7();
            return retorno;
        }
    }
}
