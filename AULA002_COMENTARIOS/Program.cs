//Diretivas using
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program 
{

    static void Main ()
    {        
        //DESCRICAO
        Console.WriteLine("\n\t***COMENTÁRIOS***\n");
        Console.WriteLine("\nOs comentarios estão no código");

        // este é um comentário em C# (LINHA UNICA)

        /* COMENTÁRIO
        DE 
        MULTIPLAS
        LINHAS*/

        /* No visual studio é possível tornar um código  em comentário através do atalho: ctrl+k,C e descomentar ctrl+K,U */

        
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