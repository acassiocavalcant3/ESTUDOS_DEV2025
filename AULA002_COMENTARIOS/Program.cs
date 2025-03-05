//Diretivas using
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program 
{

    static void Main (string[]args)
    {
        back1:
        //DESCRICAO
        Console.WriteLine("\n\t***COMENTÁRIOS***\n");
        
        // este é um comentário em C# (LINHA UNICA)

        /* COMENTÁRIO
        DE 
        MULTIPLAS
        LINHAS*/

        /* No visual studio é possível tornar um código  em comentário através do atalho: ctrl+k,C e descomentar ctrl+K,U */

        Console.WriteLine("\nDeseja executar novamente? [s/n]");
        char escolha = char.Parse(Console.ReadLine());
        if (escolha == 'S' || escolha == 's')
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