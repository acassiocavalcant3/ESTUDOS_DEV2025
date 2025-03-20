//Diretivas using
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


/*  
CONSTANTES
#As regras para declaração e atribuição de constantes são as mesmas que a das variáveis. O diferencial é elas devem obrigatoriamente ser atribuídas no momento da declaração e  uma vez atribuído o valor de uma constante futuramente o seu valor não pode ser reatribuído.

Usa a palavra reservada "const"
*/

class program
{

    static void Main()
    {
        //DESCRICAO DO ALGORITMO
        Console.WriteLine("\n\t***CONSTANTES***\n");

        //DECLARACAO DE CONSTANTES
        const int horasDoDia = 24;//se eu tentar atribuir outro valor pra essas variaveis, vai dar erro
        const float pi = 3.14f;

        Console.WriteLine("QUANTIDADE DE HORAS NO DIA E VALOR DE PI, SÃO EXEMPLOS DE CONSTANTES.");
        Console.WriteLine("HORAS DO DIA: {0}\nCONSTANTE DE PI: {1}  ",horasDoDia, pi);// usei a forma de indice para concatenar


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