//Diretivas using
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using EXERCIOS_DE_FIXACAO_SOBRE_CLASSES;


/*  
// ## EXERCICIOS DE FIXAÇÃO

001 -  ALGORITMO AREA DO RETANGULO (CURSO UDEMY - NELIO ALVES)

Fazer um programa para ler os valores da largura e altura de um retângulo. Em
seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe
como mostrado no projeto ao lado.
____________________________________________________________________________

002 -  ALGORITMO FUNCINARIO (CURSO UDEMY - NELIO ALVES)

Fazer um programa para ler os dados de um funcionário (nome,
Fazer um programa para ler os dados de um funcionário (nome,
salário bruto e imposto). Em seguida, mostrar os dados do
funcionário (nome e salário líquido). Em seguida, aumentar o salário
do funcionário com base em uma porcentagem dada (somente o
salário bruto é afetado pela porcentagem) e mostrar novamente os
dados do funcionário. Use a classe projetada abaixo.

003 -  ALGORITMO FUNCINARIO (CURSO UDEMY - NELIO ALVES)

Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver
este problema.

004 -  CONVERSOR DE MOEDA (CURSO UDEMY - NELIO ALVES)

Fazer um programa para ler a cotação do dólar e depois um valor em dólares a ser compradp por uma pessoa em reais.
Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda que a pessoa retá que pagar 6% de IOF
sobre o valor em dólar. Criar uma classe "ConversorDeMoeda" para ser responsável pelos calculos.
*/

namespace CURSO_POO_NELIO_ALVES
{

    class program
    {

        //ALGORITMO 001 - AREA DO RETANGULO
        public static Retangulo retangulo1 = new(7,15);

        //ALGORITMO 002 - FUNCIONARIO
        public static Funcionario funcionario1 = new("Acassio",1300);

        //ALGORITMO 003 - ALUNO
        public static Aluno aluno1 = new("Bia");

        public static void Main()
        {
            AlgotirmoDolar();
            //AlgotirmoAluno();
            //AlgotirmoRetangulo();
            //AlgotirmoFuncionario();
            ReiniciarPrograma();
        }

        public static void AlgotirmoDolar()
        {
            //ALGORITMO 004 - COTACAO DO DOLAR   
            Console.WriteLine("\n\t***ALGORITIMO COMPRA DE DOLARES***\n");
            Console.Write("DIGITE A COTACAO DO DOLAR: ");
            double cotacao = double.Parse(Console.ReadLine());
            Console.Write("DIGITE QUANTOS DOLARES VOCÊ QUER COMPRAR: ");
            double quantidadeDolares = double.Parse(Console.ReadLine());
            double valorCambio = ConversorDeMoeda.CalcularCambio(cotacao, quantidadeDolares);
            Console.WriteLine($"COTACAO DOLAR:............... {cotacao:c} ");
            Console.WriteLine($"QUANTIDADE:.................. {quantidadeDolares} ");
            Console.WriteLine($"VALOR A PAGAR:............... {valorCambio:c} ");
        }
        public static void AlgotirmoAluno()
        {
            //ALGORITMO 001 - FUNCIONARIO   
            Console.WriteLine("\n\t***DIGITE AS INFORMAÇOES DO ALUNO***\n");
            Console.Write("NOME: ");
            aluno1.Nome = (Console.ReadLine());
            Console.WriteLine($"\n\t***DIGITE AS NOTAS DO ALUNO***\n");
            Console.Write("NOTA 1: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("NOTA 2: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.Write("NOTA 3: ");
            double nota3 = double.Parse(Console.ReadLine());
            aluno1.CalcularNotaFinal(nota1, nota2, nota3);
            Console.WriteLine(aluno1);
        }
        public static void AlgotirmoFuncionario()
        {
            //ALGORITMO 001 - FUNCIONARIO   
            Console.WriteLine("\n\t***DIGITE AS INFORMAÇOES DO FUNCIONARIO***\n");
            Console.Write("NOME: ");
            funcionario1.Nome = (Console.ReadLine());
            Console.Write("SALARIO BRUTO: ");
            funcionario1.SalarioBruto = double.Parse(Console.ReadLine());
            Console.Write("IMPOSTOS: ");
            funcionario1.Imposto = double.Parse(Console.ReadLine());
            Console.Write(funcionario1);

            Console.Write("\nDIGITE A PORCENTAGEM PARA AUMENTAR O SALARIO: ");
            double porcentagem = double.Parse(Console.ReadLine());
            funcionario1.AumentarSalario(porcentagem);

            Console.Write("\nDADOS ATUALIZADOS", funcionario1);
            Console.WriteLine(funcionario1);

        }
        public static void AlgotirmoRetangulo()
        {
            //ALGORITMO 001 - AREA DO RETANGULO   
            Console.WriteLine("\n\t***DIGITE OS VALORES DE ALTURA E LARGURA DO RETANGULO***\n");
            System.Console.Write("ALTURA: ");
            retangulo1.Altura = double.Parse(Console.ReadLine());
            System.Console.Write("LARGURA: ");
            retangulo1.Largura = double.Parse(Console.ReadLine());
            System.Console.WriteLine(retangulo1);
        }
        public static void ReiniciarPrograma()
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

