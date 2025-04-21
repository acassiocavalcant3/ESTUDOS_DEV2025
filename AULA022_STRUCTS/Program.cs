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
         struct Carro
    {
        public string marca;
        public string modelo;
        public string cor;

        public Carro(string marca, string modelo, string cor)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
        }
    }
        static void Main()
        {
            Carro c1 = new("Toyota","Corolla", "preto");


            //METODOS DE SUPORTE DO PROGRMA
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
}
