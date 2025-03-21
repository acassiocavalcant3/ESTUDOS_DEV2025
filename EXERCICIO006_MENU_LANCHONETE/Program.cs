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
## EXERCICIO006 -  MENU LANCHONETE (CURSO UDEMY - NELIO ALVES)

Com base na tabela de preços, faça um programa que leia o código de um item e a
quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.


        CODIGO      ESPECIFICACAO        PRECO

        1           Cachorro quente      R$ 4.00
        2           X-salada             R$ 4.50
        3           X-Bacon              R$ 5.00
        4           Torrada Simples      R$ 2.00
        5           Refrigerante         R$ 1.50
*/


namespace ExercicioCsharp2025
{

    class program
    {

        static int quantidade = 0;
        static double valorProduto = 0;
        static string nomeDoProduto = "";
        static double totalDaCompra = 0;



        static void Main()
        {
            ApresentarAlgoritmo();
            SelecionarMenulanchonete();
            LerQuantidadeProduto();
            CalcularValor();
            MostrarValoresFinais();
            ReiniciarPrograma();
        }

        static void ApresentarAlgoritmo()

        {
            //EXERCÍCIO 006 -  MENU LANCHONETE      
            Console.WriteLine("\n\t***MENU LANCHONETE***\n");

        }

        static void SelecionarMenulanchonete()
        {
            Console.WriteLine("*********************************************\n");
            Console.WriteLine("******SELECIONE O LANCHE QUE VOCÊ DESEJA*****\n");
            Console.WriteLine("*********************************************\n");
            Console.WriteLine("CACHORRO QUENTE________R$_4,00_______DIGITE 1\n");
            Console.WriteLine("X-SALADA_______________R$_4,50_______DIGITE 2\n");
            Console.WriteLine("X-BACON________________R$_5,00_______DIGITE 3\n");
            Console.WriteLine("TORRADA SIMPLES________R$_2,00_______DIGITE 4\n");
            Console.WriteLine("REFRINGERANTE__________R$_1,50_______DIGITE 5\n");
            Console.WriteLine("*********************************************\n");

            int escolha = Convert.ToInt32(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    valorProduto = 4.00;
                    nomeDoProduto = "Cachorro Quente";
                    break;

                case 2:
                    valorProduto = 4.50;
                    nomeDoProduto = "X-salada";
                    break;

                case 3:
                    valorProduto = 5.00;
                    nomeDoProduto = "X-bacon";
                    break;

                case 4:
                    valorProduto = 2.00;
                    nomeDoProduto = "Torrada Simples";
                    break;

                case 5:
                    valorProduto = 1.50;
                    nomeDoProduto = "Refrigerante";
                    break;

                default:
                    Console.WriteLine("\tOPCAO INVALIDA! \nAPERTE ENTER E SELECIONE UMA OPCAO NOVAMENTE!\n");
                    Console.ReadLine();
                    Console.Clear();
                    SelecionarMenulanchonete();
                    break;
            }
        }

        static void LerQuantidadeProduto()
        {
            Console.Write($"DIGITE A QUANTIDADE DE PRODUTOS: ");
            quantidade = int.Parse(Console.ReadLine());


        }

        static void CalcularValor()
        {
            totalDaCompra = (valorProduto * quantidade);
        }


        static void MostrarValoresFinais()
        {

            Console.Clear();
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("____________________COMANDA DA LACHONETE_________________________");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*******QUANTIDADE***********************PRODUTO******************");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("          {0}                             {1}                    ", quantidade, nomeDoProduto);
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("***TOTAL A PAGAR____________________________________{0:c}........", totalDaCompra);
            Console.WriteLine("*****************************************************************");

        }
        static void ReiniciarPrograma()
        {
            Console.WriteLine("\nDeseja executar o programa novamente? [s/n]");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "s":
                case "S":
                    Console.Clear();
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
