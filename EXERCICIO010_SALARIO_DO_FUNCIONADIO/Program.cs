
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
## EXERCICIO010 -  SALARIO DO FUNCIONARIO (CURSO UDEMY - NELIO ALVES)

Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
decimais.

*/

namespace ExercicioCsharp2025
{

    class program
    {
        static string codigoFuncionario;
        static int horasTrabalhadas = 0;
        static double valorHora = 0;
        static double salarioFuncionario = 0;

        static void Main()
        {
            ApresentarAlgoritmo();
            LerCodigoFuncionario();
            LerQuantidadehorasTrabalhadas();
            LerValorHora();
            CalcularValor();
            MostrarValoresFinais();
            ReiniciarPrograma();
        }

        static void ApresentarAlgoritmo()

        {
            //EXERCÍCIO 010 - SALARIO DO FUNCIONARIO        
            Console.WriteLine("\n\t***SALARIO DO FUNCIONARIO***\n");

        }

        static void LerCodigoFuncionario()
        {             
                Console.Write("DIGITE O CODIGO DO FUNCIONARIO: ");
                codigoFuncionario = Console.ReadLine();
        }

        static void LerQuantidadehorasTrabalhadas()
        {            
                Console.Write($"DIGITE A QUANTIDADE DE HORAS TRABALHADAS: ");
                horasTrabalhadas = int.Parse(Console.ReadLine());
            

        }

        static void LerValorHora()
        {
                Console.Write($"DIGITE O VALOR DA HORA TRABALHADA: ");
                valorHora = double.Parse(Console.ReadLine());
        }

        static void CalcularValor()
        {
            salarioFuncionario = (horasTrabalhadas * valorHora);
        }


        static void MostrarValoresFinais()
        {

            Console.Clear();
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("__________________HOLERITE DO FUNCIONARIO________________________");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*********CODIGO**************VALOR HORA************HORAS*********");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("          {0}                  {2:c}                {1}         ", codigoFuncionario, horasTrabalhadas, valorHora);
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("***SALARIO LIQUIDO__________________________________{0:c}........", salarioFuncionario);
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
