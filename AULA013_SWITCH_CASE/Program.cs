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
O switch (switch case, ou escolha caso) é uma estrutura condicional que define o que será executado com base na comparação de valores.

### break
- O comando **break** é utilizado para especificar a última linha de código a ser executada dentro da condição. Se não declarado, os códigos implementados dentro dos cases subsequentes serão executados.

### default
Caso o valor do switch não seja igual a um dos valores contidos nos cases, o sistema irá executar o código implementado no bloco default.


*/

namespace AulasCsharp2025
{
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
