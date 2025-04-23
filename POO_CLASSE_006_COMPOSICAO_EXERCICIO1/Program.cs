//Diretivas using
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using POO_CLASSE_006_COMPOSICAO_EXERCICIO1.Entidades;
using POO_CLASSE_006_COMPOSICAO_EXERCICIO1.Entidades.Enums;

/*  
// ## EXERCICIOS DE FIXAÇÃO

001 -  ENUMS, CLASSE PEDIDO E ENTIDADES EM C# (CURSO UDEMY - NELIO ALVES)


*/

namespace POO_CLASSE_006_COMPOSICAO_EXERCICIO1
{

    class Program
    {

        public static void Main()
        {
            System.Console.Write("\nDigite o nome do departamento: ");
            string nomeDepartamento = (Console.ReadLine());
            System.Console.WriteLine("\nDigite os dados do trabalhador: ");
            System.Console.Write("Nome: ");
            string nome = (Console.ReadLine());
            System.Console.Write("Nivel(Junior/Intermediario/Senior): ");
            NivelDoTrabalhador nivel = Enum.Parse<NivelDoTrabalhador>(Console.ReadLine());
            System.Console.Write("Salario Base: ");
            double salarioBase = double.Parse(Console.ReadLine());

            Departamento setor = new Departamento(nomeDepartamento);
            Trabalhador funcionario = new Trabalhador(nome, nivel, salarioBase, setor);

            System.Console.Write("\nQuantos contratos? ");
            int nContratos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nContratos; i++)
            {
                System.Console.WriteLine("\n\n************************************");
                System.Console.WriteLine("_______DADOS DO CONTRATO #{0}_______",i);
                System.Console.WriteLine("************************************");
                System.Console.Write("\nDIGITE A DATA (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                System.Console.Write("DIGITE O VALOR POR HORA: ");
                double valorHora = double.Parse(Console.ReadLine());
                System.Console.Write("DIGITE A QUANTIDADE DE HORAS: ");
                int quantidadeHoras = int.Parse(Console.ReadLine());
                ContratoDeHoras contrato = new ContratoDeHoras(data, valorHora,quantidadeHoras);
                
                funcionario.AdicionarContrato(contrato);
            }            

            System.Console.Write("\nDigite o mes e o ano para calcular os ganhos do funcionario (MM/YYYY): ");
            DateTime dataPesquisada = DateTime.Parse(Console.ReadLine());
            int mes = dataPesquisada.Month;
            int ano = dataPesquisada.Year;

            System.Console.WriteLine(funcionario);
            System.Console.Write("\nSalario Final de {0}/{1}: {2:c} \n", dataPesquisada.ToString("MM"), dataPesquisada.ToString("yyyy"), funcionario.DefinirSalarioFinal(ano, mes));

            ReiniciarPrograma();
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

