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
## EXERCICIO013 -  CALCULAR AREA DOS TRIANGULOS (CURSO UDEMY - NELIO ALVES)

Fazer um programa que leia as medidas de dois triangulos X e Y (suponha medidas validas). Em seguida, mostrar o valor das areas
dos dois trinagulos e dizer qual dos dois possui a maior area.
A formula para calcular a area de um triangulo a partir de seus lados a, b, e c é a seguinte formula:

area = raiz quadrada de = p(p-a) (p-b)(p-c) onde p= ((a+b+c)/2)

*/

namespace ExercicioCsharp2025
{

    class program
    {
        public static double aX, bX, cX, aY, bY, cY, pX, pY, areaX, areaY;

        static void Main()
        {
            ApresentarAlgoritmo();
            LerDadosTrianguloX();
            LerDadosTrianguloY();
            CalcularPX();
            CalcularPY();
            CalcularAreaX();
            CalcularAreaY();
            EncontrarMaiorTriangulo();
            MostrarValoresFinais();
            ReiniciarPrograma();
        }

        static void ApresentarAlgoritmo()

        {
            //EXERCÍCIO 013 - CALCULAR AREA DOS TRIANGULOS       
            Console.WriteLine("\n\t***CALCULAR AREA DOS TRIANGULOS***\n");

        }

        static void LerDadosTrianguloX()
        {
            Console.WriteLine("DIGITE OS VALORES DO TRIANGULO X: ");

            Console.Write("DIGITE O VALOR DE A: ");
            aX = double.Parse(Console.ReadLine());

            Console.Write("DIGITE O VALOR DE B: ");
            bX = double.Parse(Console.ReadLine());

            Console.Write("DIGITE O VALOR DE C: ");
            cX = double.Parse(Console.ReadLine());


            Console.WriteLine("\nDADOS DIGITADOS! APERTE ENTER PARA CONTINUAR.\n");
            Console.ReadLine();
            Console.Clear();
        }
        static void LerDadosTrianguloY()
        {
            Console.WriteLine("DIGITE OS VALORES DO TRIANGULO Y: ");

            Console.Write("DIGITE O VALOR DE A: ");
            aY = double.Parse(Console.ReadLine());

            Console.Write("DIGITE O VALOR DE B: ");
            bY = double.Parse(Console.ReadLine());

            Console.Write("DIGITE O VALOR DE C: ");
            cY = double.Parse(Console.ReadLine());


            Console.WriteLine("\nDADOS DIGITADOS! APERTE ENTER PARA CONTINUAR.\n");
            Console.ReadLine();
            Console.Clear();
        }

        static void CalcularPX()
        {
            pX = ((aX + bX + cX) / 2);
        }
        static void CalcularPY()
        {
            pY = ((aY + bY + cY) / 2);
        }

        static void CalcularAreaX()
        {
            areaX = Math.Sqrt((pX * (pX - aX) * (pX - bX) * (pX - cX)));
        }

        static void CalcularAreaY()
        {
            areaY = Math.Sqrt((pY * (pY - aY) * (pY - bY) * (pY - cY)));
        }

        static void EncontrarMaiorTriangulo()
        {
            if (areaX > areaY)
            {
                Console.WriteLine("TRIANGULO X É O MAIOR!");
            }
            else
            {
                Console.WriteLine("TRIANGULO Y É O MAIOR!");
            }
        }


        static void MostrarValoresFinais()
        {

            // Console.Clear();
            // Console.WriteLine("*****************************************************************");
            // Console.WriteLine("__________________HOLERITE DO FUNCIONARIO________________________");
            // Console.WriteLine("*****************************************************************");
            // Console.WriteLine("*********CODIGO**************VALOR HORA************HORAS*********");
            // Console.WriteLine("*****************************************************************");
            // Console.WriteLine("          {0}                  {2:c}                {1}         ", codigoFuncionario, horasTrabalhadas, valorHora);
            // Console.WriteLine("*****************************************************************");
            // Console.WriteLine("***SALARIO LIQUIDO__________________________________{0:c}........", salarioFuncionario);
            // Console.WriteLine("*****************************************************************");

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
