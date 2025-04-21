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
## EXERCICIO015 -  ALGORITMO MEDIA COM LIST (CURSO TORNE SE UM PROGRAMADOR - DANILO APARECIDO)

MEDIA COM LIST

*/

namespace ExercicioCsharp2025
{

    class program
    {
        static void Main()
        {
            CalcularMedia();
            ReiniciarPrograma();
        }

        static void CalcularMedia()
        {
            string? nomeAluno;
            int quantidadeNotas = 4;
            double totalNotas = 0;
            double nota = 0;

            Console.Write($"\nDigite o nome do Aluno: ");
            nomeAluno = (Console.ReadLine());            
            Console.WriteLine($"Digite as {quantidadeNotas} do aluno {nomeAluno}");
            List<double> notasAluno = new List<double>();

            for (int i = 0; i < quantidadeNotas; i++)
            {
                Console.Write($"Digite a {i+1}ª nota do aluno {nomeAluno}: ");
                nota = double.Parse(Console.ReadLine());
                totalNotas += nota;
                notasAluno.Add(nota);
            }

            double mediaAluno = (totalNotas/notasAluno.Count);
            Console.WriteLine($"A media do Aluno {nomeAluno} é: {mediaAluno}");

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
