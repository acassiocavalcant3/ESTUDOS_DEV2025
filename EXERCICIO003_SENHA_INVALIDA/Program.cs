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
## EXERCICIO003 -  SENHA INVALIDA (CURSO UDEMY - OTONIEL CANDIDO)

FAÇA UM PROGRAMA  QUE REPITA A LEITURA DE UMA SENHA ATÉ QUE ELA SEJA VALIDA.PARA CADA LEITURA DE SENHA ERRADA, ESCREVA "SENHA INVALIDA".
QUANDO A SENHA FOR CERTA ESCREVA "ACESSO PERMITIDO;

*/

namespace ExercicioCsharp2025
{

    class program
    {

        static string senha = "DesenvolvedorC#";
        static string senhaDigitada;

        static void Main()
        {
            ApresentacaoAlgoritmo();
            AlgoritmoSenhaComDoWhile();
        }

        static void ApresentacaoAlgoritmo()
        {
            //DESCRICAO ALGORITIMOS WHILE E DOWHILE 
            Console.WriteLine("\n\t***ALGORITIMO SENHA***\n");
        }
        static void AlgoritmoSenhaComDoWhile()
        {
            do
            {

                Console.Write("\nDIGITE A SENHA: ");
                senhaDigitada = Console.ReadLine();


                if (senhaDigitada != senha)
                {

                    Console.Write("\nSENHA INVALIDA!");
                    Console.WriteLine("\nAPERTE ENTER PARA CONTINUAR");
                    Console.ReadLine();
                    Console.Clear();
                    Main();
                    break;
                }
                else
                {
                    Console.WriteLine($"\nAcesso liberado! Bem vindo!");
                    ReiniciarPrograma();
                }
            }
            while ((senhaDigitada != senha));



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
                    Console.Clear();
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
