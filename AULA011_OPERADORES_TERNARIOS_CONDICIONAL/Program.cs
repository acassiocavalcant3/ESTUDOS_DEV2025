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
## if else comum
- O if Else é uma estrutura condicional que define o que será executado conforme o resultado de um valor booleano.

## if else aninhado
Eu posso adicionar mais uma condição incluindo um else if, ficando três possibilidades conforme o resultado das condições

*/

class program
{

    static int nota1, nota2, nota3, nota4;
    static double media = 0;
    const double notaDecorte = 70;

    static void Main()
    {
        //DESCRICAO ESTRUTURAS CONDICIONAIS - IF E ELSE
        Console.WriteLine("\n\t***IF E ELSE - MEDIA ESCOLAR***\n");
        Console.WriteLine("DIGITE A NOTA DO 1º BIMESTRE: ");
        nota1 = int.Parse(Console.ReadLine());
        Console.WriteLine("DIGITE A NOTA DO 2º BIMESTRE: ");
        nota2 = int.Parse(Console.ReadLine());
        Console.WriteLine("DIGITE A NOTA DO 3º BIMESTRE: ");
        nota3 = int.Parse(Console.ReadLine());
        Console.WriteLine("DIGITE A NOTA DO 4º BIMESTRE: ");
        nota4 = int.Parse(Console.ReadLine());

        media = ((nota1 + nota2 + nota3 + nota4) / 4);
        Console.WriteLine(media >= notaDecorte ? "ALUNO APROVADO!" : "ALUNO REPROVADO!");
        Console.WriteLine($"Sua nota foi {media}.");

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
