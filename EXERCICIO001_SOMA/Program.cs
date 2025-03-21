//Diretivas using
using System;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


/*  
## EXERCICIO001 -  SOMA (CURSO UDEMY - OTONIEL CANDIDO)

FAÇA UM PROGRMA PARA LER DOIS VALORES E DEPOIS MOSTRAR A SOMA DESSES NÚMEROS COM UMA MENSAGEM EXPLICATIVA DO RESULTADO;

*/

namespace ExercicioCsharp2025
{

    class program
    {

        static void Main()
        {
        back1:
            //EXERCICIO 001 - SOMA
            double numero1, numero2, resultado;
            Console.WriteLine("\n\t***SOMANDO DOIS NÚMEROS***\n");
            Console.Write("DIGITE O PRIMEIRO NUMERO: ");
            numero1 = double.Parse(Console.ReadLine());//USANDO PARSE PARA A CONVERSÃO
            Console.Write("DIGITE O SEGUNDO NUMERO: ");
            numero2 = Convert.ToDouble(Console.ReadLine());//USANDO CONVERT.TO PARA A CONVERSÃO
            resultado = (numero1 + numero2);
            //resultado = (numero1 + numero2);

            Console.WriteLine($"\nO RESULTADO DA SOMA DOS DOIS NÚMEROS É\n\t\t ***{resultado}***");

            ReiniciarPrograma();

        }

        static void ReiniciarPrograma()
        {
            Console.WriteLine("\nDeseja executar o programa novamente? [s/n]");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "s":
                case "S":
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