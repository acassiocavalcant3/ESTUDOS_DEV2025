//Diretivas using
using System;
using System.Collections.Generic;
using System.Linq;


/*  
## EXERCICIO016 -  ALGORITMO FUNCIONARIO COM LIST (CURSO C# UDEMY - NELIO ALVES)

Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
N funcionários. Não deve haver repetição de id.
Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
conforme exemplos.
Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
aumento por porcentagem dada.

*/

namespace AulasCsharp2025
{

    class Program
    {
        static List<Funcionario> ListaDeFuncionarios = new();

        static void Main()
        {
            Console.Clear();
            System.Console.WriteLine();

            AdicionarFuncionarios();
            ExibirFuncinarios();
            AumentarSalarioDosFuncionarios();
            ExibirFuncinarios();
            ReiniciarPrograma();  
        }
        
        public static void AumentarSalarioDosFuncionarios()
        {
            System.Console.Write("\nDIGITE O ID DO FUNCIONARIO QUE VAI RECEBER O AUMENTO: ");
            int idAumento = int.Parse(Console.ReadLine());

            System.Console.Write("DIGITE O PERCENTUAL: ");
            decimal porcentagemAumento = decimal.Parse(Console.ReadLine());
            Funcionario funcionarioAumento = ListaDeFuncionarios.Find(f => f.IdFuncionario == idAumento);

            if (funcionarioAumento!=null)
            {
                funcionarioAumento.AumentarSalario(porcentagemAumento);
            }
            else
            {
                Console.WriteLine("ID nao encontrado!");
                ReiniciarPrograma();
            }
        }

        public static void testarClasse()
        {
            var funcionario1 = new Funcionario("Maria", 1, 1500);
            funcionario1.AumentarSalario(10); // Aumento de 10%
            Console.WriteLine(funcionario1.ToString()); // Para ver o salário aumentado
        }
        public static void AdicionarFuncionarios()
        {
            

            System.Console.Write("\nDIGITE A QUANTIDADE DE FUNCIONARIOS PARA REGISTRAR: ");//QUANTIDADE DE FUNCIONARIOS QUE VAO RECEBER AUMENTO
            int nItems = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nItems; i++)
            {
                bool IdJaFoiCadastrado;
                int id;

                do
                {
                    System.Console.WriteLine($"\nFUNCIONARIO #{i}: ");
                    System.Console.Write("DIGITE O ID DO FUNCIONARIO: ");
                    id = int.Parse(Console.ReadLine());

                    IdJaFoiCadastrado = ListaDeFuncionarios.Any(f => f.IdFuncionario == id);

                    if (IdJaFoiCadastrado)
                    {
                        Console.WriteLine("\nID JA CADASTRADO!");
                        Console.WriteLine("\nAPERTE ENTER E DIGITE UM NOVO ID!\n");
                        Console.ReadLine();
                    }

                }
                while (IdJaFoiCadastrado);

                System.Console.Write("DIGITE O NOME DO FUNCIONARIO: ");
                string? nome = (Console.ReadLine());
                System.Console.Write("DIGITE O SALARIO DO FUNCIONARIO: ");
                decimal salario = decimal.Parse(Console.ReadLine());

                ListaDeFuncionarios.Add(new Funcionario(nome, id, salario));
            }
        }
        public static void ExibirFuncinarios()
        {
            string prop1 = "ID";
            string prop2 = "NOME";
            string prop3 = "SALARIO";
            string coluna1 = prop1.ToString().PadRight(20);
            string coluna2 = prop2.ToString().PadRight(20);
            string coluna3 = prop3.ToString().PadRight(20);

            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>> <<<<<<<<<<<<<<<<<<<<<<<<<<<<\n");
            Console.WriteLine(coluna1 + coluna2 + coluna3);
            Console.WriteLine("........................................................\n");

            foreach (Funcionario item in ListaDeFuncionarios)
            {
                Console.Write(item.ToString());
            }

            Console.WriteLine("\n>>>>>>>>>>>>>>>>>>>>>>>>>>>> <<<<<<<<<<<<<<<<<<<<<<<<<<<<\n");
            ;
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
                    ListaDeFuncionarios.Clear();
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
                    ListaDeFuncionarios.Clear();
                    ReiniciarPrograma();
                    break;
            }
        }
    }
}
