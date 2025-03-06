//Diretivas using
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program 
{

    static void Main (string[] args) 
    {

    back1:
        //DESCRICÃO: MEU PRIMEIRO ALGORITMO
        Console.WriteLine("\n\t***HELLO WORLD***\n"); //ESCREVE NA TELA HELLO WORD, COM NOVA LINHA E TAB

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


