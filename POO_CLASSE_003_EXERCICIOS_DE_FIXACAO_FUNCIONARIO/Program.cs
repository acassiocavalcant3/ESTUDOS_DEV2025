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
using static System.Runtime.InteropServices.JavaScript.JSType;


/*  
## EXERCICIO013 -  CALCULAR AREA DOS TRIANGULOS (CURSO UDEMY - NELIO ALVES)

Fazer um programa que leia as medidas de dois triangulos X e Y (suponha medidas validas). Em seguida, mostrar o valor das areas
dos dois trinagulos e dizer qual dos dois possui a maior area.
A formula para calcular a area de um triangulo a partir de seus lados a, b, e c é a seguinte formula:

area = raiz quadrada de = p(p-a) (p-b)(p-c) onde p= ((a+b+c)/2)

*/

namespace CURSO_POO_NELIO_ALVES
{

    class program
    {
        //ALGORITMO TRIANGULO        
        public static Triangulo trianguloX = new();
        public static Triangulo trianguloY = new();
        public static double p, areaX, areaY;


        //ALGORIMO PESSOA
        public static Pessoa pessoaX = new();
        public static Pessoa pessoaY = new();

        //ALGORITMO FUNCIONARIO
        public static Funcionario funcionarioX = new();
        public static Funcionario funcionarioY = new();

        //ALGORITMO ESTOQUE
        //public static Produto produto1 = new(); 


        
        static void Main()
        {            
            Produto produto1 = new("TV",1000.00,30);
                        
            Console.WriteLine(produto1.NomeProduto);
            Console.WriteLine(produto1.PrecoProduto);
            Console.WriteLine(produto1.QuantidadeProduto);
            

            ////ALGORITMO TRIANGULO
            //LerDadosTrianguloX();
            //LerDadosTrianguloY();
            //MostrarAreas();
            //EncontrarMaiorTriangulo();

            ////ALGORITMO FUNCIONARIO
            //LerDadosFuncionarioX();
            //LerDadosFuncionarioY();
            //CalcularMediaSalarial(); 

            ////ALGORITMO PESSOA
            //LerDadosPessoaX();
            //LerDadosPessoaY();
            //ObterMaior();
            //

            ReiniciarPrograma();
        }





        //ALGORITMO FUNCIONARIO
        static void LerDadosFuncionarioX()
        {
            Console.WriteLine("\nDIGITE OS DADOS DO FUNCIONARIO X: ");

            Console.Write("NOME: ");
            funcionarioX.NomeFuncionario = Console.ReadLine();

            Console.Write("SALARIO: ");
            funcionarioX.SalarioFuncionario = double.Parse(Console.ReadLine());
        }
        static void LerDadosFuncionarioY()
        {
            Console.WriteLine("\nDIGITE OS DADOS DO FUNCIONARIO Y: ");

            Console.Write("NOME: ");
            funcionarioY.NomeFuncionario = Console.ReadLine();

            Console.Write("SALARIO: ");
            funcionarioY.SalarioFuncionario = double.Parse(Console.ReadLine());
        }
        static void CalcularMediaSalarial()
        {
            double media = ((funcionarioX.SalarioFuncionario + funcionarioY.SalarioFuncionario) / 2);
            Console.WriteLine("\nA media salarial nessa empresa é {0}",media);
        }


        //ALGORITMO PESSOA
        static void LerDadosPessoaX()
        {
            Console.WriteLine("\nDIGITE OS DADOS DA PESSOA X: ");

            Console.Write("NOME: ");
            pessoaX.NomePessoa = Console.ReadLine();

            Console.Write("IDADE: ");
            pessoaX.Idade = int.Parse(Console.ReadLine());
        }
        static void LerDadosPessoaY()
        {
            Console.WriteLine("\nDIGITE OS DADOS DA PESSOA Y: ");

            Console.Write("NOME: ");
            pessoaY.NomePessoa = Console.ReadLine();

            Console.Write("IDADE: ");
            pessoaY.Idade = int.Parse(Console.ReadLine());
        }
        static void ObterMaior()
        {
            if ((pessoaX.Idade > pessoaY.Idade))
            {
                Console.WriteLine("\nPessoa mais velha: {0}.", pessoaX.NomePessoa);
            }
            else
            {
                Console.WriteLine("\nPessoa mais velha: {0}.", pessoaY.NomePessoa);
            } 
        }




        //METODOS DO ALGORIMTO TRIANGULO
        static void LerDadosTrianguloX()
        {
            Console.WriteLine("DIGITE OS VALORES DO TRIANGULO X: ");

            Console.Write("DIGITE O VALOR DE A: ");
            trianguloX.LadoA = double.Parse(Console.ReadLine());

            Console.Write("DIGITE O VALOR DE B: ");
            trianguloX.LadoB = double.Parse(Console.ReadLine());

            Console.Write("DIGITE O VALOR DE C: ");
            trianguloX.LadoC = double.Parse(Console.ReadLine());
        }
        static void LerDadosTrianguloY()
        {
            Console.WriteLine("DIGITE OS VALORES DO TRIANGULO Y: ");

            Console.Write("DIGITE O VALOR DE A: ");
            trianguloY.LadoA = double.Parse(Console.ReadLine());

            Console.Write("DIGITE O VALOR DE B: ");
            trianguloY.LadoB = double.Parse(Console.ReadLine());

            Console.Write("DIGITE O VALOR DE C: ");
            trianguloY.LadoC = double.Parse(Console.ReadLine());
        }               
        static void MostrarAreas()
        {
            areaX = trianguloX.CalcularArea();
            areaY = trianguloY.CalcularArea();

            Console.WriteLine($"A AREA DE X = {areaX:f4} ");
            Console.WriteLine($"A AREA DE Y = {areaY:f4} ");
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
 