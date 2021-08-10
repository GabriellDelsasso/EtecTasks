using System;
using System.Collections.Generic;
using System.Text;

namespace Exer
{
    public class Exercicio2
    {
        public static Exercicio2 MetodoExercicio2()
        {
            string nome;
            int num2;

            do
            {
                Console.Clear();
                Console.WriteLine("\tEx - 2 Desenvolva um algoritmo que permita a entrada do nome do usuário e exiba na tela.\n");
                Console.Write("Insira seu nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("\nO nome informado é: {0}", nome);

                Console.WriteLine("\nDigite 1 para executar novamente \nDigite 2 para sair");
                num2 = int.Parse(Console.ReadLine());
            } while (num2 != 2);

            var retorno = new Exercicio2();
            return retorno;
        }
    }
}
