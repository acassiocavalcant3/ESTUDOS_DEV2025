//Diretivas using
using System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


/*  COMENTARIOS

# Array - vetores
## vetores unidimensionais

- Arrays são objetos que armazenam múltiplas variáveis de um mesmo tipo, eles são muito úteis quando trabalhamos com coleções de dados que possuem um tamanho previamente definido.
- Todo array inicia-se a partir da posição zero, ou seja, se criarmos um objeto e definirmos com o tamanho de 5 elementos, o último índice será o de valor quatro e não cinco. Se tentarmos acessar o índice cinco em um array de 5 elementos, receberemos uma exceção em tempo de execução: System.IndexOutOfRangeException.

⚠️ A primeira posição de um Array não é a posição um, ele começa do zero então um vetor de 5 posições tem os indices { 0, 1, 2, 3, 4}


*/
namespace AulasCsharp2025
{
    class program
    {
        // //
        // //DECLARACAO DE ARRAYS
        // static double[] notas = new double[4];//UM ARRAY(VETOR) DO TIPO DOUBLE COM 4 POSICOES
        // //static tipo[] nomeDoArray = new tipo[tamanhodoarray];

        // //DECLARACAO E ATRIBUICAO DE ARRAYS
        // static string[] alunos = { "Carla", "Danilo", "Eduardo", "Gustavo" };//UM ARRAY(VETOR) DO TIPO STRING COM 4 POSICOES
         //static tipo[] nomeDoArray = {valores atribuidos e separados por vírgula};




        // ////VALORES PADROES DE ARRAYS
        // static int[] arrayInt = new int[5];//VALOR PADRÃO = 0 - vetor de int 
        // static string[] arrayString = new string[5];//VALOR PADRÃO = "" - vetor de string
        // static bool[] arrayBoolean = new bool[5];//VALOR PADRÃO = FALSE - vetor de bool
        // static double[] arrayDouble = new double[5];//VALOR PADRÃO = 0.0 - vetor de double
        // //static ClasseArray[] arrayClasse = new ClasseArray[5];//VALOR PADRÃO = NULL - vetor de classe



        static void Main()
        {
            System.Console.Write("Digite a quantidade: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] vetor = new Produto[n];


            // //----------------------------------------------------------
            // Console.Write("Digite a quantidade: ");
            // int posicoesVetor =  int.Parse(Console.ReadLine());
            // double[] vetor = new double[posicoesVetor];

            // for (int i = 0; i < posicoesVetor; i++)
            // {
            //     vetor[i] = double.Parse(Console.ReadLine());
            // }

            // double soma = 0;
            // for (int i = 0; i < posicoesVetor; i++)
            // {
            //     soma += vetor[i];
            // }

            // double media = soma/posicoesVetor;

            // System.Console.WriteLine(media);

            //METODOS DE INTERAÇÃO COM O USUARIO
            //ApresentacaoAlgoritmo();

            //METODOS DE SUPORTE DO PROGRAMA
            ReiniciarPrograma();

        }




        //METODOS DE INTERAÇÃO COM O USUARIO
        static void ApresentacaoAlgoritmo()
        {
            //DESCRICAO ALGORITIMOS MEDIA COM VETORES E FOR 
            Console.WriteLine("\n\t***ALGORITIMOS APRESENTANDO ARRAYS UNIDIMENSIONAIS - VETORES***\n");

            //ATRIBUINDO VALORES INDIVIDUALMENTE
            //Eu posso atribuir valores individualmente, para isso eu inicializo o vetor e depois para atribuir eu coloco<nomeDaVariável>[posição ou índice] = valor que eu quero atribuir
            int[] vetorDeInteiro = new int[3]; //o vetor foi declarado

            vetorDeInteiro[0] = 124; // atribuindo o valor individualmente - comeca o indice do zero
            vetorDeInteiro[1] = 8; // atribuindo o valor individualmente
            vetorDeInteiro[2] = 32; // atribuindo o valor individualmente

            Console.WriteLine("VETOR DE INTEIRO NA POSICAO [0] = {0}", vetorDeInteiro[0]);//124
            Console.WriteLine("VETOR DE INTEIRO NA POSICAO [1] = {0}", vetorDeInteiro[1]);//8
            Console.WriteLine("VETOR DE INTEIRO NA POSICAO [2] = {0}", vetorDeInteiro[2]);//32
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
