//Diretivas using
using System;
using System.Collections.Generic;
using System.Linq;

namespace AulasCsharp2025
{
    /*  
    ## EXERCICIO018 -  ALGORITMO MATRIZES RECAPTULACAO 002 (CURSO C# UDEMY - NELIO ALVES)

    Fazer um programa para ler dois números inteiros M e N, e depois ler
    uma matriz de M linhas por N colunas contendo números inteiros,
    podendo haver repetições. Em seguida, ler um número inteiro X que
    pertence à matriz. Para cada ocorrência de X, mostrar os valores à
    esquerda, acima, à direita e abaixo de X, quando houver.

    */

    class Program
    {
        static int nLinhas = 0;
        static int nColunas = 0;
        static int numeroPesquisado = 0;
        static int[,] matriz;

        static void Main()
        {
            CriarMatriz();
            PreencherMatriz();
            ExibirMatriz();
            PesquisarNumeros();
            ReiniciarPrograma();
        }

        public static void CriarMatriz()
        {
            System.Console.Write("\nDIGITE A QUANTIDADE DE LINHAS DA MATRIZ: ");
            nLinhas = int.Parse(Console.ReadLine());
            System.Console.Write("DIGITE A QUANTIDADE DE COLUNAS DA MATRIZ: ");
            nColunas = int.Parse(Console.ReadLine());

            matriz = new int[nLinhas, nColunas];

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
                    Console.Write("DIGITE O NUMERO [{0},{1}]: ", linhas, colunas);
                    matriz[L, C] = int.Parse(Console.ReadLine());
                }
            }
        }
        public static void ExibirMatriz()
        {
            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("  MATRIZ [{0}]X[{1}]  ", nLinhas, nColunas);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>\n");

            for (int L = 0; L < matriz.GetLength(0); L++)// LINHAS
            {
                for (int C = 0; C < matriz.GetLength(1); C++)//COLUNAS
                {
                    int celula = matriz[L, C];

                    Console.Write($"{celula,6}");//ESCREVE O NUMERO COM 6 ESPACOS
                }

                Console.WriteLine();
            }

            Console.WriteLine("\n<<<<<<<<<<<<<<<<<<<<<\n");
        }
        public static void PesquisarNumeros()
        {
            System.Console.Write($"\nDIGITE UM NUMERO PARA PROCURAR NA MATRIZ: ");
            numeroPesquisado = int.Parse(Console.ReadLine());

            bool numeroEncontrado=false;
            for (int L = 0; L < matriz.GetLength(0); L++)// LINHAS
            {
                for (int C = 0; C < matriz.GetLength(1); C++)//COLUNAS
                {
                    var celula = matriz[L, C]; //ARMAZENA O VALOR DA CELULA ATUAL EM CELULA

                    //AQUI EU DEFINI A FORMA COMO VER AS CELULAS PROXIMAS
                    string left = (C > 0) ? matriz[L, C - 1].ToString() : " X ";//SE A COLUNA ATUAL FOR MAIOR QUE 0 PODE SE DESLOCAR A ESQUERDA;
                    string right = (C < nColunas - 1) ? matriz[L, C + 1].ToString() : " X ";//SE A COLUNA ATUAL FOR MENOR QUE A ULTIMA COLUNA (nColuna -1) PODE IR PRA DIREITA;
                    string up = (L > 0) ? matriz[L-1, C].ToString() : " X ";//SE A LINHA ATUAL FOR MAIOR QUE 0 PODE SE DESLOCAR PARA CIMA;
                    string down = (L < nLinhas - 1) ? matriz[L+1 , C].ToString() : " X ";//SE A LINHA ATUAL FOR MENOR QUE A ULTIMA LINHA (nLinha -1) PODE IR BAIXO;

                    if (numeroPesquisado == celula)
                    {
                        numeroEncontrado = true;
                        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                        Console.WriteLine(">> POSICAO:................[{0},{1}]             ", L, C);
                        Console.WriteLine(">>>ESQUERDA:...............{0}                   ", left);
                        Console.WriteLine(">>>DIREITA:................{0}                   ", right);
                        Console.WriteLine(">>>EM CIMA:................{0}                   ", up);
                        Console.WriteLine(">>>EM BAIXO:...............{0}                   ", down);
                        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");

                        Console.WriteLine(".................................................");
                    }         
                }
            }

            if(!numeroEncontrado)
            {            
                Console.WriteLine("O NUMERO NAO PERTENCE A MATRIZ!");
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
