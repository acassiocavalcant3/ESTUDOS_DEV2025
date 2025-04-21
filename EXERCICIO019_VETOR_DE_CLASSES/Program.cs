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

A dona de um pensionato possui dez quartos para alugar para estudantes,
sendo esses quartos identificados pelos números 0 a 9.
Quando um estudante deseja alugar um quarto, deve-se registrar o nome
e email deste estudante.
Fazer um programa que inicie com todos os dez quartos vazios, e depois
leia uma quantidade N representando o número de estudantes que vão
alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
N estudantes. Para cada registro de aluguel, informar o nome e email do
estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
um relatório de todas ocupações do pensionato, por ordem de quarto.

*/

namespace AulasCsharp2025
{
    class Program
    {
        static void Main()
        {
            const int quantidadeQuartos= 10;
            MoradorDeAluguel[] vetorDadosMoradores = new MoradorDeAluguel[quantidadeQuartos];
            
            System.Console.Write("DIGITE A QUANTIDADE DE QUARTOS ALUGADOS: ");
            int nPosicoes = int.Parse(Console.ReadLine());


            for (int i = 1; i <= nPosicoes; i++)
            {
                System.Console.WriteLine($"\nALUGUEL #{i}");
                System.Console.Write("NOME: ");
                string? nomeMorador = (Console.ReadLine());
                System.Console.Write("EMAIL: ");
                string? emailMorador = (Console.ReadLine());
                System.Console.Write("NUMERO DO QUARTO: ");
                int numeroQuarto = int.Parse(Console.ReadLine());

                vetorDadosMoradores[numeroQuarto] = new MoradorDeAluguel (nomeMorador, emailMorador);
            }

            System.Console.WriteLine($"\nQUARTOS OCUPADOS: ");
            foreach (MoradorDeAluguel inquilino in vetorDadosMoradores)//PERCORRENDO COM FOREACH
            {
                if (inquilino!=null)
                {
                    string texto =

                    $"**************************************************"
                    + "\nNUMERO DO QUARTO:____________" + i
                    + "\n*************************************************";
                    System.Console.WriteLine(texto + inquilino);
                }
            }


            for (int i = 0; i < quantidadeQuartos ; i++)//PERCORRENDO COM FOR
            {
                if (vetorDadosMoradores[i]!=null)
                {
                    string texto =

                    $"**************************************************"
                    + "\nNUMERO DO QUARTO:____________" + i
                    + "\n*************************************************";
                    System.Console.WriteLine(texto + vetorDadosMoradores[i]);
                }
            }

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

 