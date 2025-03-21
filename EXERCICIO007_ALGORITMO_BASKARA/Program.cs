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
## EXERCICIO006 -  ALGORITMO BASKARA (CURSO UDEMY - NELIO ALVES)

Ler os valores dos três coeficientes "a", "b" e "c" de uma equação do segundo grau (ax ao quadrado + bx + c = 0)

Em seguida, mostrar os valores das raízes da equação, conforme exemplos, usando a fórmula de Baskara (veja
abaixo). Se a equação não possuir raízes (o valor de "a" não pode ser zero, e o valor de "delta" não pode ser
negativo), mostrar uma mensagem "Impossivel calcular".


Fórmula: X = -b+ou-2a sobre 2a

onde:

delta = b ao quadrado -4ac

*/

namespace ExercicioCsharp2025
{

    class program
    {
        static double a, b, c, delta, x, x1, x2 = 0;
        static double raizDeDelta = 0;

        static void Main()
        {
            ApresentarAlgoritmo();
            LerCoeficientes();
            CalcularDelta();
            CalcularRaizDeDelta();
            CalcularX();
            MostrarValoresFinais();
            ReiniciarPrograma();
        }

        static void ApresentarAlgoritmo()

        {
            //EXERCÍCIO 007 -  ALGORITMO BASKARA    
            Console.WriteLine("\n\t***ALGORITMO BASKARA***\n");

        }

        static void LerCoeficientes()
        {
            Console.Write($"DIGITE O VALOR DE A: ");
            a = double.Parse(Console.ReadLine());

            Console.Write($"DIGITE O VALOR DE B: ");
            b = double.Parse(Console.ReadLine());

            Console.Write($"DIGITE O VALOR DE C: ");
            c = double.Parse(Console.ReadLine());
        }

        static void CalcularDelta()
        {

            delta = ((b * b) - 4 * a * c);
        }
        static void CalcularRaizDeDelta()
        {
            raizDeDelta = Math.Sqrt(delta);

        }

        static void CalcularX()
        {
            x1 = ((-b + raizDeDelta) / (2 * a));
            x2 = ((-b - raizDeDelta) / (2 * a));
        }
        static void MostrarValoresFinais()
        {

            Console.Clear();
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("____________________ALGORITMO BASKARA____________________________");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*******A********************B**********************C*************");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine($"      {0}                  {1}                    {2}             ", a, b, c);
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*****************************************************************");

            if ((a == 0) || delta < 0)
            {
                Console.WriteLine("***X1_____________________IMPOSSIVEL CALCULAR");
                Console.WriteLine("***X2_____________________IMPOSSIVEL CALCULAR");
                Console.WriteLine("*****************************************************************");
            }
            else
            {
                Console.WriteLine($"***X1______________________________________{x1:F4}");
                Console.WriteLine($"***X2______________________________________{x2:F4}");
                Console.WriteLine("*****************************************************************");
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
