
//Diretivas using
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


/*  
## EXERCICIO012 -  NUMEROS MULTIPLOS (CURSO UDEMY - NELIO ALVES)

Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
ordem crescente ou decrescente.

*/

namespace ExercicioCsharp2025
{

    class program
    {

        static int a, b = 0;

        static void Main()
        {
            ApresentarAlgoritmo();
            LerNumerosDigitados();
            ConferirNumeros();
            ReiniciarPrograma();
        }

        static void ApresentarAlgoritmo()

        {
            //EXERCICIO010 -  POSITIVO OU NEGATIVO       
            Console.WriteLine("\n\t***ALGORITMO POSITIVO OU NEGATIVO***\n");

        }

        static void LerNumerosDigitados()
        {
            Console.Write("DIGITE O PRIMEIRO NUMERO PARA VER SE ELES SAO MULTIPLOS: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("DIGITE O SEGUNDO NUMERO PARA VER SE ELES SAO MULTIPLOS: ");
            b = int.Parse(Console.ReadLine());


        }


        static void ConferirNumeros()
        {
            if ((a % b == 0)|| (b % a == 0))
            {
                Console.WriteLine("\nSAO MULTIPLOS!");
            }
            else
            {
                Console.WriteLine("\n\nNAO SAO MULTIPLOS!");
            }
        }


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
