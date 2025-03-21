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
## EXERCICIO005 -  CALCULAR A AREA DE UM CIRCULO (CURSO UDEMY - NELIO ALVES)

Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
casas decimais conforme exemplos.

Fórmula: area = π.raio ao quadrado
Considere o valor de π = 3.14159

*/
namespace ExercicioCsharp2025
{

    class program
    {
        static double raio = 0;
        static double area = 0;
        static double raioAoQuadrado = 0;


        const double pi = 3.14159;

        static void Main()
        {
            ApresentarAlgoritmo();
            LerValorRaio();
            CalcularRaioAoQuadrado();
            CalcularArea();
            MostrarValoresFinais();
            ReiniciarPrograma();
        }

        static void ApresentarAlgoritmo()

        {
            //EXERCÍCIO 005 -  CALCULE O VALOR DA AREA        
            Console.WriteLine("\n\t***ALGORITMO CIRCULO***\n");

        }
        static void LerValorRaio()
        {

            Console.Write("DIGITE O VALOR DO RAIO: ");
            raio = double.Parse(Console.ReadLine());

        }
        static void CalcularRaioAoQuadrado()
        {

            raioAoQuadrado = (raio * raio);

        }
        static void CalcularArea()
        {
            area = (pi * raioAoQuadrado);

        }



        static void MostrarValoresFinais()
        {

            Console.Clear();
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("_______________ALGORITMO AREA DE UM CIRCULO______________________");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("********   RAIO  *****************    AREA    *******************");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine($"........   {raio}   .................     {area:F4}    ...................", raio, area);
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
