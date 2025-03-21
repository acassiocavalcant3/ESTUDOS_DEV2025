//Diretivas using
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*  Um escopo é um ambiente onde a variável pode ser acessada. É uma área de atuação da variável;

    Não podemos usar uma variável antes de atribuir um valor a ela.

    Quando eu abro um bloco de códigos, abro chaves, chamamos isso de ESCOPO.As variáveis atribuídas nesse escopo só valem dentro desse contexto de chaves.Já as variáveis criadas
    atribuídas em uma hierarquia maior do escopo, por exemplo, um método Main, ou uma classe, vao ter um contexto maior de atuação.

    Portanto as variáveis criadas e atribuídas em um escopo pai(variável global), podem ser utilizadas em escopos filhos. Mas uma variável criada e atribuída em um escopo filho(variável local), não existe no contexto de um escopo pai
*/

namespace AulasCsharp2025
{
    class program
    {

        static int numeroVG = 10;

        static void Main()//ESCOPO 1  
        {
        back1:
            //DESCRICAO
            Console.WriteLine("\n\t***ESCOPO DE VARIAVEIS***\n");


            //nesse caso numeroVL só funciona dentro do escopo  do metodo main. Se eu tentar trabalhar com ele em outro
            int numeroVL = 10;
            int soma = numeroVL + numeroVG;
            ;

            Console.WriteLine("SE SAIU A VARIAVEL LOCAL O VALOR DA VARIAVEL É 10:" + numeroVL);
            Console.WriteLine("SE SAIU A VARIAVEL LOCAL O VALOR DA VARIAVEL É 20:" + soma);

            ReiniciarPrograma();
        }

        /*
            //aqui esta comentado, senao o codigo daria erro, pois a variavel numeroVL não é reconhecida, pois nao foi atribuida nesse escopo do metodo secundario

        static void secundario()//ESCOPO 2
        {
            Console.WriteLine("\n\t***VARIAVEL DENTRO DO ESCOPO. NUMERO: ", numeroVL); //a variavel numeroVL não é reconhecida, pois nao foi atribuida nesse escopo do metodo secundario
        } 
        */

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
