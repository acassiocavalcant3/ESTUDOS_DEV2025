//Diretivas using
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


/*  
TIPOS DE CONVERSOES
# Convertsao implicita
Conversão implícita: é aquela em que não é necessário nenhum código especial, pois se trata de uma conversão segura, sem risco de perda de dados;

# Parse
converte uma variável não string para o formato desejado usando .Parse após o tipo de dado desejado. O parse sempre converte uma string para outro tipo;
ESTA É UMA ANOTACAO


# Convert.To
converte a variável para o tipo que quiser;

# (CASTs)
esse tipo de conversão necessita de um operador. É realizado quando há a necessidade de se converter um valor e pode ocorrer perda de informações.

*/

namespace AulasCsharp2025
{
    class program
    {

        static void Main()
        {
            //DESCRICAO DO ALGORITMO
            Console.WriteLine("\n\t***CONVERSOES DE VARIAVEIS***\n");

            //DECLARACAO DE VARIAVEIS
            int numeroParaConverter = 2000;
            int numeroParaConverter2 = 0;
            double doubleParaConverter = 1200.50;
            string nomeParaConverter = "123";


            //# Convertsao implicita
            decimal numeroConvertido = numeroParaConverter; // conversão implícita. nao há perda de dados
            Console.WriteLine("CONVERSAO IMPLICITA: INT PARA DECIMAL (NÃO HÁ PERDA DE DADOS)");
            Console.WriteLine("RESULTADO: 2000 ......  " + numeroConvertido);

            //# (CASTs)
            numeroParaConverter2 = (int)doubleParaConverter;//convertento o double para int (perde a precisão)
            Console.WriteLine("\n***CONVERSAO CAST: DOUBLE PARA INT (PERDE A PRECISAO) ***");
            Console.WriteLine("***RESULTADO: 1200 ......  " + numeroParaConverter2);

            // # Parse
            Console.WriteLine("\n***CONVERSAO PARSE: DIGITE UM NUMERO PRA SER CONVERTIDO ***");
            int numeroParaConverter3 = int.Parse(Console.ReadLine()); //convertento uma entrada de texto para numero inteiro (int)
            int soma = (numeroParaConverter3 + 10);
            Console.WriteLine("\n***RESULTADO: SEU NUMERO + 10 ......  " + soma);
            Console.WriteLine("\n***CONVERSAO PARSE PARA BOOL ***");
            bool boolParaConverter = bool.Parse("false"); //CONVERSAO DE TEXTO PRA BOOL 
            Console.WriteLine("***RESULTADO:  ......  " + boolParaConverter);

            // # Convert.To
            Console.WriteLine("\n***CONVERSAO CONVERT.TO: STRING PARA INT ***\n");
            int numeroConvertido2 = Convert.ToInt32(nomeParaConverter); // conversão implícita. nao há perda de dados
            Console.WriteLine("***RESULTADO: 123 + 10 ......  " + (numeroConvertido2 + 10));

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
