//Diretivas using
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using POO_CLASSE_005_ENUMS_PEDIDOS_ENTIDADES.Entidades;
using POO_CLASSE_005_ENUMS_PEDIDOS_ENTIDADES.Entidades.Enums;

/*  
// ## EXERCICIOS DE FIXAÇÃO

001 -  ENUMS, CLASSE PEDIDO E ENTIDADES EM C# (CURSO UDEMY - NELIO ALVES)


*/

namespace POO_CLASSE_005_ENUMS_PEDIDOS_ENTIDADES
{

    class Program
    {

        


        public static void Main()
        {
            Pedido lanche = new Pedido
            {
                Id = 1080,
                HoraDoPedido = DateTime.Now,
                Status = StatusDoPedido.Processando
            };

            //CONVERTENDO ENUM PARA STRING
            string enumParaTexto = StatusDoPedido.Pendende.ToString();

            /*CONVERTENDO STRING PARA ENUM (FORMA 1)
            TipoDoEnum  nomeEnum = Enum(com e maisculo).Parse<TipoDoEnum>("string correspondente a um ENUM")*/
            StatusDoPedido textoParaEnum1 = Enum.Parse<StatusDoPedido>("Processando");

            /*CONVERTENDO STRING PARA ENUM (FORMA 2)
            TipoDoEnum  nomeEnum = (TipoDoEnum)Enum.Parse(typeof(TipoDoEnum), ("string correspondente a um ENUM")*/
            StatusDoPedido textoParaEnum2 = (StatusDoPedido)Enum.Parse(typeof(StatusDoPedido), "Enviado");

            /*CONVERTENDO STRING PARA ENUM (FORMA 3)
            TipoDoEnum  nomeEnum;
            Enum.TryParse("string correspondente a um ENUM", out nomeEnum)*/
            StatusDoPedido textoParaEnum3;  
            Enum.TryParse("Entregue", out textoParaEnum3);


            Console.WriteLine(enumParaTexto);
            Console.WriteLine(textoParaEnum1);
            Console.WriteLine(textoParaEnum2);
            Console.WriteLine(textoParaEnum3);



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

