//Diretivas using
using System;
using System.Collections.Generic;
using System.Linq;

namespace AulasCsharp2025
{
    /*  
    ## EXERCICIO017 -  ALGORITMO MATRIZES RECAPTULACAO (CURSO C# UDEMY - NELIO ALVES)

    Fazer um programa para ler um número inteiro N e uma matriz de
    ordem N contendo números inteiros. Em seguida, mostrar a diagonal
    principal e a quantidade de valores negativos da matriz.

    */

    class Program
    {
        static int nCelulas = 0;
        static int[,] matriz;

        static void Main()
        {

            CriarMatriz();
            PreencherMatriz();
            ExibirMatriz();
            MostrarDiagonal();
            MostrarNegativos();
            ReiniciarPrograma();
        }

        public static void CriarMatriz()
        {
            System.Console.Write("\nDIGITE A PROPORCAO DA MATRIZ: ");
            nCelulas = int.Parse(Console.ReadLine());

            matriz = new int[nCelulas, nCelulas];

        }
        public static void PreencherMatriz()
        {
            Console.WriteLine();
            for (int L = 0; L < matriz.GetLength(0); L++)// LINHAS
            {
                for (int C = 0; C < matriz.GetLength(1); C++)//COLUNAS
                {
                    int linhas = L + 1;
                    int colunas = C + 1;
                    Console.Write("DIGITE O NUMERO [{0},{1}]: ",linhas,colunas);
                    matriz[L, C] = int.Parse(Console.ReadLine());                    
                }         
            }
        }
        public static void ExibirMatriz()
        {
            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("  MATRIZ [{0}]X[{1}]  ", nCelulas, nCelulas);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>\n");

            for (int L = 0; L < matriz.GetLength(0); L++)// LINHAS
            {
                for (int C = 0; C < matriz.GetLength(1); C++)//COLUNAS
                {
                    int celula = matriz[L, C];

                    Console.Write($"{celula,6}");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n<<<<<<<<<<<<<<<<<<<<<\n");
        }
        public static void MostrarDiagonal()
        {
            System.Console.Write($"\nNumeros diagonal: ");
            List<int> listaDiagonal = new();

            for (int L = 0; L < matriz.GetLength(0); L++)// LINHAS
            {
                for (int C = 0; C < matriz.GetLength(1); C++)//COLUNAS
                {
                    if (L == C)
                    {
                        int celula = matriz[L, C];
                        System.Console.Write(celula + "   ");
                    }
                }
            }
        }
        public static void MostrarNegativos()
        {
            List<int> listaDeNegativos = new();

            for (int L = 0; L < matriz.GetLength(0); L++)// LINHAS
            {
                for (int C = 0; C < matriz.GetLength(1); C++)//COLUNAS
                {
                    int celula = matriz[L, C];

                    if (celula < 0)
                    {
                        listaDeNegativos.Add(celula);
                    }
                }
            }

            int quantidadeNegativos = listaDeNegativos.Count();

            System.Console.Write("\nNumeros negativos: {0}\n", quantidadeNegativos);

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
