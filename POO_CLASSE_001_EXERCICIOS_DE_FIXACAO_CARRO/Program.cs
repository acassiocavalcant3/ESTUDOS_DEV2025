//Diretivas using
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


/*  
## EXERCICIO015 -  ALGORITMO MEDIA COM LIST (CURSO TORNE SE UM PROGRAMADOR - DANILO APARECIDO)

MEDIA COM LIST

*/

namespace Exercicios_POO_2025
{

    class program
    {
        static void Main()
        {
            Funcionario funcionario1 = new Funcionario();
            Console.Write("\nDigite o nome do funcionario: ");
            funcionario1._nomeFuncionario = (Console.ReadLine());

            Console.Write("Digite o cargo do funcionario: ");
            funcionario1._cargo = (Console.ReadLine());

            Console.Write("Digite o salario do funcionario: ");
            funcionario1._salarioBase = decimal.Parse(Console.ReadLine());

            funcionario1.CalcularSalario();

            Console.WriteLine(funcionario1);

            // ContaBancaria conta1 = new ContaBancaria();
            // Console.Write("\nDigite o nome do titular da conta: ");
            // conta1._titular = (Console.ReadLine());

            // Console.Write("Digite o numero da conta: ");
            // conta1._numeroConta = (Console.ReadLine());

            // conta1.Depositar(100m);
            // conta1.Sacar(50.89m);

            // Console.WriteLine(conta1);
            
            
            // Livro livro1 = new Livro();

            // Console.Write("Digite o titulo do livro: ");
            // livro1.tituloLivro = (Console.ReadLine());

            // Console.Write("Digite o nome do autor do livro: ");
            // livro1.autorLivro = (Console.ReadLine());

            // Console.Write("Digite o ano do livro: ");
            // livro1.anoLivro = int.Parse(Console.ReadLine());
            
            // livro1.Emprestar();

            // Console.WriteLine(livro1);



            // Carro carro1 = new Carro();

            // Console.Write("Digite o nome do dono do carro: ");
            // carro1.nomeDono = (Console.ReadLine());

            // Console.Write("Digite o modelo do carro: ");
            // carro1.modelo = (Console.ReadLine());

            // Console.Write("Digite o ano do carro: ");
            // carro1.ano = int.Parse(Console.ReadLine());
            
            // Console.Write("Digite a cor do carro: ");
            // carro1.cor = (Console.ReadLine());
            // Console.WriteLine(carro1);


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
