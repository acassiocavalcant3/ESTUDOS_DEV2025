
//Diretivas using
using System;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


/*  /*  
## EXERCICIO009 -  LER QUATRO NUMEROS INTEIROS E CALCULAR A DIFERENCA (CURSO UDEMY - NELIO ALVES)

Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
*/

namespace ExercicioCsharp2025
{
    class program
    {
        //VARIAVEIS GLOBAIS
        static int a, b, c, d = 0;
        static int diferenca = 0;
        static int foraDoIntervalo = 0;


        static void Main()
        {

            //METODOS DE INTERAÇÃO COM O USUARIO
            ApresentacaoAlgoritmo();

            //METODOS DE ENTRADA
            LerNumeroDeEntrada();

            //METODO DE PROCESSAMENTO
            CalcularDiferenca();

            //METODO DE SAIDA
            MostrarResultadoNotas();

            //METODOS DE SUPORTE DO PROGRMA
            ReiniciarPrograma();

        }




        //METODOS DE INTERAÇÃO COM O USUARIO
        static void ApresentacaoAlgoritmo()
        {
            //LER QUATRO NUMEROS INTEIROS E CALCULAR A DIFERENCA
            Console.WriteLine("\n\t***ALGORITIMOS LER QUATRO NUMEROS INTEIROS E CALCULAR A DIFERENCA***\n");


        }

        //METODOS DE ENTRADA//SELECIONA QUANTOS NUMEROS O USUARIO IRA DIGITAR
        static void LerNumeroDeEntrada()
        {
            Console.Write($"DIGITE O VALOR DE A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write($"DIGITE O VALOR DE B: ");
            b = int.Parse(Console.ReadLine());

            Console.Write($"DIGITE O VALOR DE C: ");
            c = int.Parse(Console.ReadLine());

            Console.Write($"DIGITE O VALOR DE D: ");
            d = int.Parse(Console.ReadLine());
        }        

        //METODO DE PROCESSAMENTO
        static void CalcularDiferenca()
        {
            diferenca = ((a * b) - (c * d));
        }

        //METODO DE SAIDA//CONDICIONAL COM IF ANINHADO
        static void MostrarResultadoNotas()
        {
            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("___CALCULANDO A DIFERENCA_\n");
            Console.WriteLine("****************************");
            Console.WriteLine("***NUMEROS DIGITADOS:_______");
            Console.WriteLine($"A = {a},B = {b},C = {c},D = {d}");
            Console.WriteLine("****************************");
            Console.WriteLine("***DIFERENÇA_________  {0}", diferenca);
            Console.WriteLine("**********************************");
            Console.Write("\nTecle enter continuar... \n");
            Console.ReadLine();
        }

        //METODOS DE SUPORTE DO PROGRAMA
        static void ReiniciarPrograma()
        {
            Console.WriteLine("\nDeseja executar o programa novamente? [s/n]");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "s":
                case "S":

                    Console.Clear();
                    Main();
                    break;

                case "n":
                case "N":
                    break;

                default:
                    Console.WriteLine("******************************************************");
                    Console.WriteLine("\tOPCAO INVALIDA! \nAPERTE ENTER E SELECIONE UMA OPCAO NOVAMENTE!\n");
                    Console.ReadLine();
                    Console.Clear();
                    ReiniciarPrograma();
                    break;
            }
        }
    }
}
