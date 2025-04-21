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

# LISTAS - vetores

*/

namespace AulasCsharp2025
{
    class Program
    {
        static void Main()
        {
            //METODO Add//METODO PARA ADICIONAR A LISTA
            List<string> listaDeNomes = new List<string>();
            listaDeNomes.Add("Acassio");
            listaDeNomes.Add("Jonas");
            listaDeNomes.Add("Bia");
            listaDeNomes.Add("Bianca");
            listaDeNomes.Add("Marco");
            listaDeNomes.Add("Mario");
            listaDeNomes.Add("Maria");

            //METODO Insert//METODO PARA INSERIR NA LISTA NO INDICE QUE QUISER
            listaDeNomes.Insert(2, "Jhonatan");

            foreach (string nome in listaDeNomes)
            {
                System.Console.WriteLine(nome);
            }

            //PROPRIEDADE Count//PARA DESCOBRIR A QUANTIDADE DE ELEMENTOS NA LISTA
            System.Console.WriteLine($"QUANTIDADE DE ELEMENTOS NA LISTA DE NOMES: {listaDeNomes.Count}");

            //METODO Find//USA EXPRESSOES LAMBDA E PROCURA A PRIMEIRA OCORRENCIA, PRIMEIRA PALAVRA QUE COMECA COM B
            string primeiroNome = listaDeNomes.Find(x => x[0] == 'B');
            System.Console.WriteLine("\nPRIMEIRO NOME NA LISTA QUE COMEÇA COM N: " + primeiroNome);

            //METODO FindLast//USA EXPRESSOES LAMBDA E PROCURA A ULTIMA OCORRENCIA, ULTIMA PALAVRA QUE COMECA COM B
            string ultimoNome = listaDeNomes.FindLast(x => x[0] == 'B');
            System.Console.WriteLine("\nULTIMO NOME NA LISTA QUE COMEÇA COM B: " + ultimoNome);

            //METODO FindIndex//USA EXPRESSOES LAMBDA E PROCURA O INDICE DA PRIMEIR OCORRENCIA, PRIMEIRA PALAVRA QUE COMECA COM B
            int primeiroIndex = listaDeNomes.FindIndex(x => x[0] == 'B');
            System.Console.WriteLine("\nULTIMO INDICE NA LISTA QUE COMEÇA COM B: " + primeiroIndex);

            //METODO FindLastIndex//USA EXPRESSOES LAMBDA E PROCURA O INDICE DA ULTIMA OCORRENCIA, ULTIMA PALAVRA QUE COMECA COM B
            int ultimoIndex = listaDeNomes.FindLastIndex(x => x[0] == 'B');
            System.Console.WriteLine("\nULTIMO INDICE NA LISTA QUE COMEÇA COM B: " + ultimoIndex);

            //METODO FindAll//USA EXPRESSOES LAMBDA E FILTRA A LISTA E RETORNA UMA LISTA APENAS COM OS ELEMENTOS FILTRADOS
            List<string> listaFiltrada = listaDeNomes.FindAll(x => x.Length == 5);//filtra nomes com 5 caracteres
            System.Console.WriteLine("\nLISTA FILTRADA (apenas nomes com 5 caracteres): ");
            foreach (string nome in listaFiltrada)
            {
                System.Console.WriteLine(nome);
            }

            //METODO Remove//REMOVE UM ELEMENTO
            listaDeNomes.Remove("Acassio");// 
            //METODO RemoveAt//REMOVE UM ELEMENTO COM BASE NO INDICE
            listaDeNomes.RemoveAt(4);//


            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("LISTA DE NOMES APOS REMOCAO de Acassio e do elemento na posicao 4");
            foreach (string nome in listaDeNomes)
            {
                System.Console.WriteLine(nome);
            }


            //METODO RemoveAll//USA PREDICADO E REMOVE DA LISTA UMA PALAVRA QUE COMECA COM M
            listaDeNomes.RemoveAll(x => x[0] == 'M');// 
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("LISTA DE NOMES APOS REMOCAO");
            foreach (string nome in listaDeNomes)
            {
                System.Console.WriteLine(nome);
            }

            //METODO RemoveRange//REMOVE DA LISTA UMA PALAVRA QUE COMECA COM M
            listaDeNomes.RemoveRange(2,2);// remove pelo indice e depois 
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("LISTA DE NOMES APOS REMOCAO");
            foreach (string nome in listaDeNomes)
            {
                System.Console.WriteLine(nome);
            }







            //METODOS DE SUPORTE DO PROGRMA
            ReiniciarPrograma();
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

