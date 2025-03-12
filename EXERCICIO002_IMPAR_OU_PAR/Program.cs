// See https://aka.ms/new-console-template for more information
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
## EXERCICIO002 -  É IMPAR OU PAR? (CURSO UDEMY - OTONIEL CANDIDO)

FAÇA UM PROGRMA PARA LER UM NÚMERO INTEIRO E DEPOIS DIZER SE ESTE NÚMERO É IMPAR OU PAR;

*/

class program
{

    static void Main(string[] args)
    {
    back1:
        //EXERCÍCIO 002 -  ÍMPAR OU PAR
        int oNumeroDeEntrada;
        Console.WriteLine("\n\t***DESCOBRINDO SE UM NUMERO E ÍMPAR OU PAR***\n");
        Console.Write("DIGITE UM NÚMERO: ");
        oNumeroDeEntrada = int.Parse(Console.ReadLine());//USANDO PARSE PARA A CONVERSÃO
        
        if ((oNumeroDeEntrada % 2== 1))
        {
            Console.Write($"\nO NUMERO {oNumeroDeEntrada} É ÍMPAR!: \n");
        }
        else
        {
            Console.Write($"\nO NUMERO {oNumeroDeEntrada} É PAR!: \n");
        }

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