//Diretivas using
using System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


/*  COMENTARIOS

# Array - matrizes
## Vetores Bidimensionais

Uma matriz é praticamente como um vetor, mas eu posso utilizar dois índices para controlar os elementos do array.  É mais ou menos como uma tabela eu tenho um índice para a linha e um índice para a coluna.

## declaração de matrizes
A declaração de arrays bidimensionais é algo relativamente simples no C#. No entanto, é importante destacar que é essencial sabermos exatamente o tamanho que o array terá, o que acaba sendo uma limitação em alguns casos.

A declaração padrão para uma matriz, diferente de um array padrão, obedece a seguinte estrutura, com uma vírgula no meio para separar os índices de linhas e os de colunas:

*/
namespace AulasCsharp2025
{
    class program
    {
        //

        ////VALORES PADROES DE ARRAYS
        //static int[] arrayInt = new int[5];//VALOR PADRÃO = 0 - vetor de int 
        //static string[] arrayString = new string[5];//VALOR PADRÃO = "" - vetor de string
        //static bool[] arrayBoolean = new bool[5];//VALOR PADRÃO = FALSE - vetor de bool
        //static double[] arrayDouble = new double[5];//VALOR PADRÃO = 0.0 - vetor de double
        ////static ClasseArray[] arrayClasse = new ClasseArray[5];//VALOR PADRÃO = NULL - vetor de classe


        static void Main()
        {

            //METODOS DE INTERAÇÃO COM O USUARIO
            ApresentacaoAlgoritmo();

            //METODOS DE SUPORTE DO PROGRMA
            ReiniciarPrograma();

        }




        //METODOS DE INTERAÇÃO COM O USUARIO
        static void ApresentacaoAlgoritmo()
        {
            //DESCRICAO ALGORITIMOS MEDIA COM VETORES E FOR 
            Console.WriteLine("\n\t***ALGORITIMOS APRESENTANDO ARRAYS UNIDIMENSIONAIS - VETORES***\n");

            //DECLARACAO DE ARRAYS (matrizes)
            double[,] notas = new double[3, 3];//UM ARRAY(MATRIZ) DO TIPO DOUBLE COM 9 POSICOES (3X3)
                                               //static tipo[,] nomeDoArray = new tipo[linhas,colunas]

            //DECLARACAO E ATRIBUICAO DE ARRAYS

            /*
                10    19    15
                23    29    40
                60    71    56             
            */

            int[,] matrizInt = new int[4, 3];//inicialização da matriz

            //                      coluna 0                 coluna 1                  coluna 2
            /* linha 0*/
            matrizInt[0, 0] = 10; matrizInt[0, 1] = 19; matrizInt[0, 2] = 15;

            /* linha 1*/
            matrizInt[1, 0] = 23; matrizInt[1, 1] = 29; matrizInt[1, 2] = 40;

            /* linha 2*/
            matrizInt[2, 0] = 60; matrizInt[2, 1] = 71; matrizInt[2, 2] = 56;



            Console.WriteLine("*******************");
            Console.WriteLine("{0}\t{1}\t{2}", matrizInt[0, 0], matrizInt[0, 1], matrizInt[0, 2]); // 10, 19, 15
            Console.WriteLine("{0}\t{1}\t{2}", matrizInt[1, 0], matrizInt[1, 1], matrizInt[1, 2]); // 23, 29, 40
            Console.WriteLine("{0}\t{1}\t{2}", matrizInt[2, 0], matrizInt[2, 1], matrizInt[2, 2]); // 60, 71, 56
            Console.WriteLine("******************\n");
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
