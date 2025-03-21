//Diretivas using
using System;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


/*  ### WHILE
Na estrutura de repetição while (enquanto), o bloco irá se repetir enquanto a condição ser verdadeira. 
Nessa estrutura de repetição, não precisamos saber quantas vezes ela repetirá.

while(condição)//REPETE SE FOR VERDADEIRA, SENAO SAI DO BLOCO
{
	//bloco de código
    contador++
}
Podemos forçar que essa condição seja atendida, para evitar um looping infinito. 
Para isso precisamos declarar uma variável contador fora do While e depois adicionar a variável contador
e fazer com que ela seja incrementada ao fim da execução do bloco de código.

Ou então eu posso forçar a parada do looping com um condicional onde a instrução seria um break;

⚠️ O bloco de código dentro de um while, pode não ser executado nenhuma vez ⚠️

*/


/*  ### DO - WHILE
A estrutura de repetição do-while (faça-enquanto) funciona semelhantemente ao while, 
porém ela garante que o bloco de código seja executado, ao menos uma vez.

do
{
		//bloco de código
        contador++

}
while(condição);



Podemos forçar que essa condição seja atendida, para evitar um looping infinito. 
Para isso precisamos declarar uma variável contador fora do DO_While e depois adicionar a variável contador
e fazer com que ela seja incrementada ao fim da execução do bloco de código.

Ou então eu posso forçar a parada do looping com um condicional onde a instrução seria um break;

⚠️ O bloco de código dentro de um while, pode não ser executado nenhuma vez ⚠️

*/

namespace AulasCsharp2025
{
    class program
    {
        static string senha = "1234";
        static string username = "admin";
        static string senhaDigitada;
        static string usernameDigitado;
        static int tentativas = 0;

        static void Main()
        {
            Console.Clear();
            //METODOS DE INTERAÇÃO COM O USUARIO
            ApresentacaoAlgoritmo();

            //METODOS DE PROCESSAMENTO

            AlgoritmoSenhaComDoWhile();
            AlgoritmoNumeroParComWhile();

            //METODOS DE SUPORTE DO PROGRMA
            ReiniciarPrograma();

        }




        //METODOS DE INTERAÇÃO COM O USUARIO
        static void ApresentacaoAlgoritmo()
        {
            //DESCRICAO ALGORITIMOS WHILE E DOWHILE 
            Console.WriteLine("\n\t***ALGORITIMOS SENHA COM DOWHILE E NUMERO PAR COM WHILE***\n");

        }

        //METODOS DE PROCESSAMENTO
        static void AlgoritmoNumeroParComWhile()
        {
            Console.Write("\nDigite um numero par: ");

            int numeroDigitado1 = int.Parse(Console.ReadLine());


            while ((numeroDigitado1 % 2 == 1))
            {
                Console.WriteLine("******************************************************");
                Console.WriteLine("\tESTE NUMERO É NÃO É PAR!\nAPERTE ENTER E SELECIONE UMA OPCAO NOVAMENTE!\n");
                Console.ReadLine();
                Console.Write("\nDigite um numero par: ");

                numeroDigitado1 = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("\nIsso mesmo! {0} é um número par! ", numeroDigitado1);
            Console.WriteLine("\nAPERTE ENTER PARA CONTINUAR");
            Console.ReadLine();
        }

        static void AlgoritmoSenhaComDoWhile()
        {
            do
            {
                tentativas++;
                Console.Write("\nSENHA: ");
                senhaDigitada = Console.ReadLine();

                Console.Write("LOGIN: ");
                usernameDigitado = Console.ReadLine();


                if (tentativas == 3)
                {
                    Console.Clear();
                    Console.Write("\nACESSO NEGADO! VOCÊ ERROU A SENHA MAIS DE {0} VEZES. SUA SENHA FOI CANCELADA. ", tentativas);
                    Console.WriteLine("\nAPERTE ENTER PARA CONTINUAR");
                    Console.ReadLine();
                    tentativas = 0;
                    Main();
                    break;
                }
                else
                {
                    continue;
                }
            }
            while ((senhaDigitada != senha) || (usernameDigitado != username));

            Console.WriteLine($"\nAcesso liberado! Bem vindo {username}!");

        }






        //METODOS DE SUPORTE DO PROGRAMA
        static void ReiniciarPrograma()
        {
            tentativas = 0;
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