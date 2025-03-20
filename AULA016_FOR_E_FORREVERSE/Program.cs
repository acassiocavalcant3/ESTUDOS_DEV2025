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
 ### FOR
O for é uma estrutura de repetição que utilizamos quando sabemos a quantidade de repetições que um bloco irá se repetir. Por isso, nessa estrutura temos um contador, uma condição e um incremento. No for quando a condição for verdadeira, será executado.

for (contador; (condição); contador++) 
{
		//bloco de código
}

### FOR REVERSE
O for é uma estrutura de repetição que utilizamos quando sabemos a quantidade de repetições que um bloco irá se repetir. Por isso, nessa estrutura temos um contador, uma condição e um incremento.

*/

class program
{
    //VARIAVEIS GLOBAIS
    static double[] notas = new double[4];//UM ARRAY(VETOR) DO TIPO DOUBLE COM 4 POSICOES
    static double media = 0;
    const int notaDeCorte = 70;


    static void Main()
    {

        //METODOS DE INTERAÇÃO COM O USUARIO
        ApresentacaoAlgoritmo();

        //METODOS DE ENTRADA
        //PerguntarMediasComVetorEFor(); // com FOR
        PerguntarMediasComVetorEForReverse(); // com FOR REVERSE 

        //METODO DE PROCESSAMENTO
        CalcularMedia();

        //METODO DE SAIDA
        MostrarResultadoNotas();

        //METODOS DE SUPORTE DO PROGRMA
        ReiniciarPrograma();

    }




    //METODOS DE INTERAÇÃO COM O USUARIO
    static void ApresentacaoAlgoritmo()
    {
        //DESCRICAO ALGORITIMOS MEDIA COM VETORES E FOR 
        Console.WriteLine("\n\t***ALGORITIMOS MEDIA COM VETORES, FOR E FOR REVERSE***\n");


    }

    //METODOS DE ENTRADA
    static void PerguntarMediasComVetorEFor()
    {
        //ALGORITMO MEDIA DE NOTA COM FOR

        for (int contador = 0; contador < notas.Length; contador++) //for tradicional//vetor de 4 posicoes
        {
        back:
            Console.Write($"DIGITE A NOTA DO {contador + 1}º BIMESTRE: ");
            notas[contador] = double.Parse(Console.ReadLine());
            if ((notas[contador] > 100) || ((notas[contador] < 0)))//caso digite um numero fora do range (0 - 100)
            {
                Console.WriteLine("\tNOTA INVALIDA! DIGITE UMA NOTA ENTRE 0 E 100 \nAPERTE ENTER E SELECIONE UMA OPCAO NOVAMENTE!\n");
                Console.ReadLine();
                goto back;

            }
            else
            {
                //
            }
        }

    }

    static void PerguntarMediasComVetorEForReverse()
    {
        //ALGORITMO MEDIA DE NOTA COM FOR REVERSE

        for (int contador = notas.Length - 1; contador >= 0; contador--) //for tradicional//vetor de 4 posicoes
        {
        back1:
            Console.Write($"DIGITE A NOTA DO {contador + 1}º BIMESTRE: ");
            notas[contador] = double.Parse(Console.ReadLine());

            if ((notas[contador] > 100) || ((notas[contador] < 0)))//caso digite um numero fora do range (0 - 100)
            {
                Console.WriteLine("\tNOTA INVALIDA! DIGITE UMA NOTA ENTRE 0 E 100 \nAPERTE ENTER E SELECIONE UMA OPCAO NOVAMENTE!\n");
                Console.ReadLine();
                goto back1;

            }
            else
            {
                //
            }
        }
    }

    //METODO DE PROCESSAMENTO
    static void CalcularMedia()
    {   //IMPORTANTE LEMBRAR QUE OS INDICES COMECAM EM ZERO    
        media = ((notas[0] + notas[1] + notas[2] + notas[3]) / 4);
    }

    //METODO DE SAIDA//CONDICIONAL COM IF ANINHADO
    static void MostrarResultadoNotas()
    {
        //IF CONDICIONAL DA MEDIA
        if (media < 50)//condição 
        {
            Console.Clear();
            Console.WriteLine("Aluno reprovado! ");
            Console.WriteLine($"Sua Media foi: {media}");

        }
        else if (media >= 50 && media < 70)
        {
            Console.Clear();
            Console.WriteLine("Ficou de Recuperacao! ");
            Console.WriteLine($"Sua Media foi: {media}");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Parabens! voce foi aprovado! ");
            Console.WriteLine($"Sua Media foi: {media}");
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