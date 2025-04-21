//Diretivas using
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

#ARRAYS DE CLASSES -  CURSO UDEMY - NELIO ALVES

FAZER UM PROGRAMA PARA LER UM NÚMERO INTEIRO N E OS DADOS (NOME E PREÇO) DE N PRODUTOS.
ARMAZENE OS N PRODUTOS EM UM VETOR. EM SEGUIDA, MOSTRAR O PRECO MEDIO DOS PRODUTOS.


*/

namespace AulasCsharp2025
{
    class program
    {
        static void Main()
        {
            System.Console.Write("DIGITE UMA QUANTIDADE: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vetorDeProdutos = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                System.Console.Write("\nDIGITE O NOME DO PRODUTO: ");
                string nomeProduto = (Console.ReadLine());
                System.Console.Write("\nDIGITE O PRECO DO PRODUTO: ");
                decimal precoProduto = decimal.Parse(Console.ReadLine());
                vetorDeProdutos[i] = new Produto {NomeProduto = nomeProduto, PrecoProduto = precoProduto};

            }
            decimal soma =0;
            for (int i = 0; i < n; i++)
            {
                soma += vetorDeProdutos[i].PrecoProduto;
            }

            decimal media =  soma / n;

            System.Console.WriteLine($"Media dos preços: {media:c}");



            //METODOS DE SUPORTE DO PROGRMA
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

