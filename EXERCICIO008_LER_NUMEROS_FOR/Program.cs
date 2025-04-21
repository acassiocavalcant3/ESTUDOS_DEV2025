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
## EXERCICIO008 -  LER NUMEROS DENTRO DE UM INTERVALO USANDO FOR(CURSO UDEMY - NELIO ALVES)

Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
*/

namespace ExercicioCsharp2025
{
    class program
    {
        //VARIAVEIS GLOBAIS
        static int xVezes = 0;
        static List <double> numerosDigitados = new List <double> ();
        static int dentroDoIntervalo = 0;
        static int foraDoIntervalo = 0;


        static void Main()
        {

            //METODOS DE INTERAÇÃO COM O USUARIO
            ApresentacaoAlgoritmo();

            //METODOS DE ENTRADA
            LerNumeroDeEntrada();
            LerNumerosComWhile();

            //METODO DE PROCESSAMENTO
            CalcularIntervalo();

            //METODO DE SAIDA
            MostrarResultadoNotas();

            //METODOS DE SUPORTE DO PROGRMA
            ReiniciarPrograma();

        }




        //METODOS DE INTERAÇÃO COM O USUARIO
        static void ApresentacaoAlgoritmo()
        {
            //LER NUMEROS DENTRO DE UM INTERVALO USANDO FOR
            Console.WriteLine("\n\t***ALGORITIMOS LER NUMEROS DENTRO DE UM INTERVALO USANDO FOR***\n");


        }

        //METODOS DE ENTRADA//SELECIONA QUANTOS NUMEROS O USUARIO IRA DIGITAR
        static void LerNumeroDeEntrada()
        {
            Console.Write($"QUANTOS NUMEROS VOCÊ DESEJA DIGITAR? ");
            xVezes = int.Parse(Console.ReadLine());


            while ((xVezes <= 0) || (xVezes > 10))
            {
                Console.Clear();
                Console.WriteLine("\tNUMERO INVALIDO! DIGITE UM NUMERO ENTRE 0 E 10! \n\nAPERTE ENTER E SELECIONE UMA OPCAO NOVAMENTE!\n");
                Console.ReadLine();
                Console.Clear();                
                Main();
            }

        }

        static void LerNumerosComWhile()
        {
            //SO CONSEGUI FAZER COM LIST
            Console.Clear();
            int contador = 0;

            while (contador < xVezes)
            {
                Console.Write($"DIGITE O {contador + 1}º NUMERO: ");
                numerosDigitados.Add(double.Parse(Console.ReadLine()));
                contador++;
            }
        }


        //METODO DE PROCESSAMENTO
        static void CalcularIntervalo()
        {
            foreach (double item in numerosDigitados)
            {
                if ((item >= 10) && (item <= 20))
                {
                    dentroDoIntervalo++;
                }
                else
                {
                    foraDoIntervalo++;
                }
            }
        }

        //METODO DE SAIDA//CONDICIONAL COM IF ANINHADO
        static void MostrarResultadoNotas()
        {
            Console.Clear();
            Console.WriteLine("****************************");
            Console.WriteLine("___NUMEROS ENTRE 10 E 20__\n");
            Console.WriteLine("****************************");
            Console.WriteLine("***NUMEROS DIGITADOS:_______");
            Console.WriteLine("****************************");
            foreach (double item in numerosDigitados)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("****************************");
            Console.WriteLine("***DENTRO:___________  {0}", dentroDoIntervalo);
            Console.WriteLine("***FORA:_____________  {0}", foraDoIntervalo);
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
