using System;
using System.Collections.Generic;
using System.Text;

namespace Exer
{
    public class Exercicio5
    {
        public static Exercicio5 MetodoExercicio5()
        {
            Console.Clear();
            Console.WriteLine("\tEx - 5 Desenvolva um método que receba por parâmetro o um nome, \n\te retorne a frase “Olá meu nome é: { nome recebido}”.\n");
            Console.Write("Digite seu nome: ");
            var nome = Console.ReadLine();
            Console.Clear();

            Metodo(nome);

            var retorno = new Exercicio5();
            return retorno;
        }
        private static void Metodo(string nome)
        {
            Console.WriteLine("Olá meu nome é: {0}", nome);
        }
    }
}
