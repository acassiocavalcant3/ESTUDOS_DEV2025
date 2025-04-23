//Diretivas using
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


/*  COMENTARIOS

#DATATIME -  CURSO UDEMY - NELIO ALVES
📚 Exercício sugerido pela IA

Crie um programa que:

Leia a data de nascimento do usuário.
Calcule quantos dias ele viveu até hoje.
Mostre em tela: “Você já viveu X dias!”

*/

namespace AulasCsharp2025
{
    class Program
    {
        static DateTime dataAtual = DateTime.Now;
        static DateTime dataDeNascimento;
        static int tempoVivo = 0;


        static void Main()
        {
            //DATETIME E TIMESPAN SAO DO TIPO STRUCT - TIPO VALOR
            //DATETIME UM MOMENTO (15/05/2023 13H00MIN) 
            //TIME SPAN REPRESENTA UM INTERVALO ENTRE DOIS MOMENTOS (2 dias, 4horas e dois segundos)


            //PARSEEXACT

            //ALGUMAS PROPRIDADES DO DATETIME
            DateTime agora = DateTime.Now; // data e hora da maquina local
            DateTime hoje = DateTime.Today;// data de hoje as 00h 
            DateTime utcHora = DateTime.UtcNow;// data e hora do fusohorario de Greenwich  

            TimeSpan jogoDeFutebol = new TimeSpan(1, 30, 00);
            TimeSpan daquiMeiaHora = TimeSpan.FromMinutes(30);

            Console.WriteLine(jogoDeFutebol);
            Console.WriteLine(daquiMeiaHora);
            Console.WriteLine(hoje);
            Console.WriteLine(agora);
            Console.WriteLine(utcHora);

            PedirDadosDeIdade();
            CalcularDiasDeVida();
            //METODOS DE SUPORTE DO PROGRMA
            ReiniciarPrograma();
        }

        static void InformacoesDateTime()
        {
            
        }

        static void PedirDadosDeIdade()
        {
            System.Console.Write("\nDIGITE SUA DATA DE NASCIMENTO (dd/MM/yyyy): ");
            dataDeNascimento = DateTime.Parse(Console.ReadLine());
        }
        static void CalcularDiasDeVida()
        {
            TimeSpan tempoDeVida = (dataAtual - dataDeNascimento);
            tempoVivo = tempoDeVida.Days;

            System.Console.Write("\nVocê já viveu {0} dias! ", tempoVivo);

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

