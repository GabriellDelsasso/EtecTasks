using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Exer
{
    public class Exercicio8
    {
        public static Exercicio8 MetodoExercicio8()
        {
            Console.Clear();

            Console.WriteLine("\tEx - 8 Desenvolva um algoritmo que solicite a entrada de nome, e-mail, telefone e RG de \n\tum determinado usuário e grave em um arquivo de texto. Exiba as informações \n\tna tela a partir do arquivo de texto gerado.\n");
            Console.Write("Informe seu nome: ");
            var nome = Console.ReadLine();

            Console.Write("Informe seu e-mail: ");
            var email = Console.ReadLine();

            Console.Write("Informe seu telefone: ");
            var telefone = Console.ReadLine();

            Console.Write("Informe seu RG: ");
            var rg = Console.ReadLine();

            StreamWriter gravador = new StreamWriter("C:\\Users\\gabriell\\Documents\\Exercícios\\Exer\\Exercicio 8.txt");
            gravador.WriteLine(nome);
            gravador.WriteLine(email);
            gravador.WriteLine(telefone);
            gravador.WriteLine(rg);
            gravador.Close();

            Console.WriteLine("Foi gerado um arquivo txt com as informações");

            string info;

            StreamReader leitor = new StreamReader("C:\\Users\\gabriell\\Documents\\Exercícios\\Exer\\Exercicio 8.txt");
            info = leitor.ReadLine();
            while (info != null)
            {
                Console.WriteLine(info);
                info = leitor.ReadLine();
            }
            leitor.Close();

            var retorno = new Exercicio8();
            return retorno;
        }
    }
}
