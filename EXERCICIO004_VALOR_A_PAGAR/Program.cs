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
## EXERCICIO004 -  VALOR A PAGAR (CURSO UDEMY - NELIO ALVES)

Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.

*/

namespace ExercicioCsharp2025
{

    class program
    {
        static string[] codigoPeca = new string[2];
        static int[] quantidadePeca = new int[2];
        static double[] valorPeca = new double[2];
        static double subtotal1 = 0;
        static double subtotal2 = 0;
        static double totalDaCompra = 0;

        static void Main()
        {
            ApresentarAlgoritmo();
            LerCodigoPeca();
            LerQuantidadePeca();
            LerValorPeca();
            CalcularValor();
            MostrarValoresFinais();
            ReiniciarPrograma();
        }

        static void ApresentarAlgoritmo()

        {
            //EXERCÍCIO 004 -  VALOR A PAGAR        
            Console.WriteLine("\n\t***ALGORITMO AUTOPECAS***\n");

        }

        static void LerCodigoPeca()
        {
            for (int i = 0; i < codigoPeca.Length; i++)
            {
                Console.Write("DIGITE O CODIGO DA PECA {0}: ", (i + 1));
                codigoPeca[i] = Console.ReadLine();
            }
        }

        static void LerQuantidadePeca()
        {
            for (int i = 0; i < quantidadePeca.Length; i++)
            {
                Console.Write($"DIGITE A QUANTIDADE DAS PECAS {i + 1}: ");
                quantidadePeca[i] = int.Parse(Console.ReadLine());
            }

        }

        static void LerValorPeca()
        {
            for (int i = 0; i < valorPeca.Length; i++)
            {
                Console.Write($"DIGITE O VALOR UNITÁRIO DA PECA {i + 1}: ");
                valorPeca[i] = double.Parse(Console.ReadLine());
            }
        }

        static void CalcularValor()
        {
            subtotal1 = (quantidadePeca[0] * valorPeca[0]);
            subtotal2 = (quantidadePeca[1] * valorPeca[1]);
            totalDaCompra = (subtotal1 + subtotal2);
        }


        static void MostrarValoresFinais()
        {

            Console.Clear();
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("_______________________ALGORITMO AUTOPEÇAS_______________________");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*********CODIGO****QUANTIDADE****VALOR UNITARIO****SUBTOTAL");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("COMPRA1...{0}.........{1}...........{2:c}...........{3:c}..", codigoPeca[0], quantidadePeca[0], valorPeca[0], subtotal1);
            Console.WriteLine("COMPRA2...{0}.........{1}...........{2:c}...........{3:c}..", codigoPeca[1], quantidadePeca[1], valorPeca[1], subtotal2);
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("***TOTAL A PAGAR____________________________________{0:c}........", totalDaCompra);
            Console.WriteLine("*****************************************************************");

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
