//Diretivas using
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*  
## O que é Enum?

1. Enums (enumerations ou enumerações, em português) são constantes estáticas que podem receber uma quantidade de valores, conforme for atribuído e conforme o índice. Como constantes, são geralmente usados para valores que em geral não mudam. 
2. É como se criássemos o nosso próprio "tipo de variável" que na verdade é uma constante. 
3. Parece uma classe, com a diferença que não instanciamos  e nem precisamos instanciar objetos

## Como criamos e atribuimos um enum?
1. Os enums por serem estáticos, devem ser atribuidos dentro da classe e não dentro da main. Mas são acessados dentro da main com <NomeDoEnum>.<Parametrocriado>
2. Digitamos o comando enum, (NÃO É DENTRO DA MAIN) atribuimos o nome do enum que queremos (precisa ser um nome de facil identificação no contexto do projeto) abrimos chaves e inserimos os valores predefinidos que esse tipo poderá receber e apósas chaves colocamos ponto e vírgula. 
3. O nome do enum deve começar com letra maiuscula e os parâmetros tambem
4. enum + <NomeDoEnum> { Parametro1, Parametro2, Parametro3... };

## ESCOPO DO ENUM
1. o enum funcionara dentro da classe que ele foi atribuido e nos escopos internos a classe;   
2. Se eu quiser usar esse enum em uma outra classe, dependendo da classe eu devo conceder o acesso adionando ao enum o modificador de acesso public. Então pra chamar em outra classe ficaria: <NomeDaclasse>.<NomeDoEnum>.<parametro>, como no exemplo abaixo:
3. Program.DiasSemana.Segunda

⚠️ NÃO SE ATRIBUI  enum DENTRO DE MÉTODOS!
⚠️ DEVEM SER ATRIBUIDOS DENTRO DE UMA CLASSE

*/

namespace AulasCsharp2025
{

    class program
    {

        enum DiasDaSemana//PASCAL CASE
        {
            Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado

        };

        enum PeriodosDoDia//PASCAL CASE
        {
            Matutino, Vespertino, Noturno

        };

        static void Main()
        {
        back1:
            //DESCRICAO
            Console.WriteLine("\n\t***ENUMERADORES (ENUMS)***\n");

            DiasDaSemana dia = DiasDaSemana.Domingo;
            PeriodosDoDia periodo = PeriodosDoDia.Noturno;

            Console.WriteLine("TESTANDO ENUMERADORES (ENUMS) \n\nEU COSTUMO IR PARA A IGREJA NO {0}, NO PERIODO {1}", dia, periodo);
            Console.WriteLine("**********************************\n");
            Console.WriteLine("PRESSIONE ENTER PRA CONTINUAR");
            Console.ReadKey(); //DEIXA O CURSOR AGUARDANDO O ENTER 
            Console.Clear();//LIMPA A TELA

            //ALGORITMO TESTE2
            Console.WriteLine("QUAL DIA DA SEMANA É HOJE?\n");
            Console.WriteLine("DIGITE O NÚMERO CORRESPONDENTE: ");
            Console.WriteLine("0 - DOMINGO\n" + "1 - SEGUNDA\n" + "2 - TERÇA\n" + "3 - QUARTA\n" +
            "4 - QUINTA\n" + "5 - SEXTA\n" + "6 - SABADO\n");
            DiasDaSemana diaSemana = (DiasDaSemana)Convert.ToInt32(Console.ReadLine());
            /*o numero digitado é captado com o metodo Console.ReadLine(),então mesmo sendo um numero, ele é do tipo string. Convertemos o numero digitado de string pra int, com o métododo convert.To e depois fazemos cast de enum, passando o numero como indice;*/
            Console.WriteLine("\nQUAL PERIODO DO DIA É AGORA?\n");
            Console.WriteLine("DIGITE O NÚMERO CORRESPONDENTE: ");
            Console.WriteLine("0 - MATUTINO\n" + "1 - VESPERTINO\n" + "2 - NOTURNO\n");
            PeriodosDoDia periodoDia = (PeriodosDoDia)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("TESTANDO ENUMERADORES (ENUMS: \n\nNO MOMENTO DA EXECUCAO DESSE ALGORITMO, É {0}, NO PERÍODO {1}", diaSemana, periodoDia);
            Console.WriteLine("**********************************\n");


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
