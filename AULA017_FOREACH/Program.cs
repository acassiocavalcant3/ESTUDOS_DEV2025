//Diretivas using
using System;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


/*  COMENTARIOS

# **FOREACH*

O **foreach** é um recurso do **C#** que possibilita executar um conjunto de comandos para cada elemento presente em uma coleção (Array, List, Stack, Queue e outras). Portanto, diferente do while e do for, não precisamos definir uma condição de parada. Isso é definido de forma implícita, pelo tamanho da coleção.


⚠️ O tipo do elemento deve ser o mesmo da coleção ⚠️ 



Sintaxe da estrutura de repetição foreach:

foreach (tipo elemento in coleção)
{
    //bloco de código
}

Na declaração do foreach, entre parênteses criamos um elemento do tipo utilizado na coleção e, com o operador in, informamos a coleção a ser percorrida. Assim, a cada loop os dados presentes em uma posição da coleção são atribuídos ao elemento. Por fim, entre chaves, inserimos o código a ser executado no loop.


*/
namespace AulasCsharp2025
{
    class program
    {
        static void Main()
        {

            //METODOS DE INTERAÇÃO COM O USUARIO
            ApresentacaoAlgoritmo();


            //METODOS DE SUPORTE DO PROGRMA
            ReiniciarPrograma();
        }




        //METODOS DE INTERAÇÃO COM O USUARIO
        static void ApresentacaoAlgoritmo()
        {
            //Considere que desejamos imprimir na tela todos os nomes presentes em um array.
            //Para isso, em vez de criar um while e nos preocuparmos com a condição de parada, podemos fazer uso do foreach.

            string[] vetorDeNomes = { "André", "Bruno", "Carla", "Daniel" };

            Console.WriteLine("\n\t***UTILIZANDO O FOREACH PARA PERCORRER UM ARRAY***\n");
            Console.WriteLine("******************************************************\n");
            Console.WriteLine("OS NOMES PRESENTES NO VETOR DE NOMES SÃO:             \n");

            foreach (string item in vetorDeNomes)
            {
                Console.WriteLine(item);
            }



        }



        //METODOS DE SUPORTE DO PROGRAMA
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