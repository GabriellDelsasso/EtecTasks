using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Exer
{
    public class Exercicio9
    {
        public static Exercicio9 MetodoExercicio9()
        {
            float peso, altura, imc;
            string info;

        inicio:
            Console.Clear();

            try
            {
                Console.WriteLine("\tEx - 9 Desenvolva um algoritmo que calcule o IMC de uma determinada pessoa, e grave os \n\tresultados em um arquivo de texto, onde ao acessar a aplicação será solicitado se quer \n\tfazer um novo cadastro ou consultar os existentes. Cadastrando um novo calculo de IMC, \n\tserá necessário informar o nome, idade, peso e altura. O cálculo do IMC é feito \n\tdividindo o peso (em quilogramas) pela altura (em metros) ao quadrado. \n\tAo gravar em um arquivo de texto, os dados anteriores deverão ser mantidos.\n");
                Console.WriteLine("\tEscolha uma opção digitando o número correspondente");
                Console.WriteLine("\n1-Novo Cadastro \n2-Consultar cadastros \n3-Sair");
                var escolha = int.Parse(Console.ReadLine());

                if (escolha == 1)
                {
                    Console.Write("Informe o seu nome: ");
                    var nome = Console.ReadLine();

                    Console.Write("Informe sua idade: ");
                    var idade = Console.ReadLine();

                    Console.Write("Informe seu peso em Kg: ");
                    peso = float.Parse(Console.ReadLine());

                    Console.Write("Informe sua altura em metros: ");
                    altura = float.Parse(Console.ReadLine());

                    imc = peso / (altura * altura);

                    try
                    {
                        StreamWriter gravador = new StreamWriter("C:\\Users\\gabriell\\Documents\\Exercícios\\TdExer\\Exercicio 9.txt", true);
                        gravador.WriteLine("----------------------------");
                        gravador.WriteLine("Nome: {0}", nome);
                        gravador.WriteLine("Idade: {0}", idade);
                        gravador.WriteLine("Peso: {0}", peso);
                        gravador.WriteLine("Altura: {0}", altura);
                        gravador.WriteLine("IMC: {0}", imc);
                        gravador.WriteLine("----------------------------");
                        gravador.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exceção: " + e.Message);
                    }
                    goto inicio;
                }
                else if (escolha == 2)
                {
                    try
                    {
                        StreamReader leitor = new StreamReader("C:\\Users\\gabriell\\Documents\\Exercícios\\TdExer\\Exercicio 9.txt");
                        info = leitor.ReadLine();
                        while (info != null)
                        {
                            Console.WriteLine(info);
                            info = leitor.ReadLine();
                        }
                        leitor.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exceção: " + e.Message);
                    }
                }
                else if (escolha == 3)
                {
                    goto fim;
                }
                else
                {
                    Console.WriteLine("Digite um dos números que corresponde a uma escolha \n\nPressione a tecla enter");
                    Console.ReadLine();
                    Console.Clear();
                    goto inicio;
                }
            fim:;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exceção: " + e.Message);
            }
            var retorno = new Exercicio9();
            return retorno;
        }
    }
}
