//Diretivas using
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


using CURSO_POO_NELIO_ALVES;

/*  
// ## EXERCICIOS DE FIXAÇÃO

001 -  ALGORITMO CONTA BANCARIA (CURSO UDEMY - NELIO ALVES)

Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do
titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito
inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua
conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.
Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já
o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por
exemplo).
Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger
isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque
realizado, o banco cobra uma taxa de $ 5.00. Nota: a conta pode ficar com saldo negativo se o saldo não for
suficiente para realizar o saque e/ou pagar a taxa.
Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não
informado o valor de depósito inicial. Em seguida, realizar um depósito e depois um saque, sempre
mostrando os dados da conta após cada operação.
*/

namespace CURSO_POO_NELIO_ALVES
{

    class Program
    {
        public static void Main()
        {
            AlgotirmoContaBancaria();
            ReiniciarPrograma();
            //AlgotirmoAluno();
            //AlgotirmoRetangulo();
            //AlgotirmoFuncionario();
        }
        

        //ALGORITMO 001 - CONTA BANCARIA
        public static void AlgotirmoContaBancaria()
        {
            //ALGORITMO 001 - CONTA BANCARIA  

            ContaBancaria novaConta1;

            Console.WriteLine("\n\t***ALGORITIMO CONTA BANCARIA***\n");
            Console.Write("DIGITE O NUMERO DA CONTA: ");
            int nConta = int.Parse(Console.ReadLine());
            Console.Write("DIGITE O NOME DO TITULAR DA CONTA: ");
            string titular = (Console.ReadLine());
            Console.Write("HAVERÁ DEPOSITO INICIAL (S/N)? ");
            string opcaoDigitada = (Console.ReadLine());
            bool escolha = ContaBancaria.ChecarDepositoInicial(opcaoDigitada);
            if (escolha)
            {
                Console.Write("DIGITE O VALOR DO DEPOSITO INICIAL: ");
                decimal valorDeposito = decimal.Parse(Console.ReadLine());
                novaConta1 = new(nConta, titular, valorDeposito);
            }
            else
            {
                novaConta1 = new(nConta, titular);
            }

            
            Console.WriteLine(novaConta1);
            Console.Write("DIGITE O VALOR DO DEPOSITO: ");
            decimal dinheiro = decimal.Parse(Console.ReadLine());
            novaConta1.Depositar(dinheiro);

            Console.Write("DADOS ATUALIZADOS");
            Console.WriteLine(novaConta1);

            Console.Write("DIGITE O VALOR DO SAQUE: ");
            dinheiro = decimal.Parse(Console.ReadLine());
            novaConta1.Sacar(dinheiro);

            Console.Write("DADOS ATUALIZADOS");
            Console.WriteLine(novaConta1);
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

