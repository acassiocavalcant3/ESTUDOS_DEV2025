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
# Comando goto

- O comando goto serve para criar um marcador (label) e retornar a execução para um ponto específico que quiser do código.
- o marcador ou label deve ser criado com: <nomeDoMarcador>:
Depois pra chamar é só colocar o código goto <nomeDoMarcador>;

Por exemplo:  Numa estrutura de escolha caso (switch case) eu posso colocar um go to para retornar ao inicio da estrutura quando a opçao selecionada for errada;
*/

class program
{

    static string linguagemDeProgramacao;

    static void Main()
    {
    back1:
    inicio:
        Console.WriteLine("escolha uma linguagem de programacao");
        Console.WriteLine("Digite 1 para Javascript");
        Console.WriteLine("Digite 2 para C#");

        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:

                Console.WriteLine("selecionou a opcao 1");
                linguagemDeProgramacao = "Javascript";
                break;
            case 2:
                Console.WriteLine("Selecionou a opcao 2");
                linguagemDeProgramacao = "C#";
                break;
            default:
                //caso o usuario digite algo que nao seja um ou dois, retorna ao inicio do programa
                Console.WriteLine("Opcao invalida! tecle enter para continuar...");
                Console.ReadLine();
                goto inicio;
                Console.Clear();
                break;
        }
            Console.WriteLine($"voce escolheu a linguagem de programacao {linguagemDeProgramacao}.");

            Console.WriteLine("\nDeseja executar novamente? [s/n]");
            string escolha = Console.ReadLine();
            if (escolha == "S" || escolha == "s")
            {
                Console.Clear();
                goto back1;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nFim da execução. Tecle enter para sair... \n");
                Console.ReadLine();
            }
        }

}

