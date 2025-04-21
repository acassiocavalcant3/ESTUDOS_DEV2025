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
## EXERCICIO010 -  POSITIVO OU NEGATIVO (CURSO UDEMY - NELIO ALVES)

Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

*/

namespace ExercicioCsharp2025
{

    class program
    {
        
        static int numeroDigitado = 0;
        static double valorHora = 0;
        static double salarioFuncionario = 0;

        static void Main()
        {
            ApresentarAlgoritmo();
            LerNumeroDigitado();            
            ConferirNumero();
            ReiniciarPrograma();
        }

        static void ApresentarAlgoritmo()

        {
            //EXERCICIO010 -  POSITIVO OU NEGATIVO       
            Console.WriteLine("\n\t***ALGORITMO POSITIVO OU NEGATIVO***\n");

        }

        static void LerNumeroDigitado()
        {
            Console.Write("DIGITE UM NUMERO PARA DESCOBRIR SE ELE É POSITIVO OU NEGATIVO: ");
            numeroDigitado = int.Parse(Console.ReadLine());
        }


        static void ConferirNumero()
        {
            if (numeroDigitado<0)
            {
                Console.WriteLine("\nO NUMERO {0} É NEGATIVO", numeroDigitado);
            }
            else
            {
                Console.WriteLine("\nO NUMERO {0} É POSITIVO", numeroDigitado);
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
