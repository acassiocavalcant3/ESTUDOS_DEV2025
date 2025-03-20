//Diretivas using
using System;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


/*  
## Formatação de strings no console

# Pular a linha \n
o caractere **\n** é o mesmo que o enter, então ele pula uma linha

# Tabulação \t
O caractere \t é o mesmo que o TAB, então ele dá um espaço maior

# Formatação com índices (interpolação)
No começo dos parênteses eu coloco $ e abro aspas e adiciono o nome das variáveis que eu quero adicionar naquele ponto específico dentro de chaves{ }

# Formatação com índices (placeholders)  
Dentro da string eu adiciono um índice para uma variável que eu quero adicionar naquele ponto com { }, (índices sempre começam com o número 0)

⚠️ NÃO SE ATRIBUI  enum DENTRO DE MÉTODOS!
⚠️ DEVEM SER ATRIBUIDOS DENTRO DE UMA CLASSE

*/

class program
{

    static string nome = "Maria";
    static int idade = 30;
    static double saldo = 250.6542;

    static void Main()
    {    
        //DESCRICAO ALGOTIMOS COM TECNICAS PARA FORMATAR STRINGS
        Console.WriteLine("\n\t***FORMATACAO DE STRINGS***\n");



        //FormatarComBarraNeBarrat();
        //Interpolacao();
        //Placeholders();
        //AdicionarEspacoes();
        //FormatacaoMonetaria();
        //FormatacaoPorcentagem();

        MenuFormatarStrings();

        ReiniciarPrograma();
    }

    static void FormatarComBarraNeBarrat()
    {
        Console.WriteLine("\tFORMATANDO STRINGS\n");//# Pular a linha \n    //# Tabulação \t
        Console.WriteLine("**********************************\n");
        Console.WriteLine("PRESSIONE ENTER PRA CONTINUAR");
        Console.ReadKey(); //DEIXA O CURSOR AGUARDANDO O ENTER 
        Console.Clear();//LIMPA A TELA
    }

    static void Interpolacao()
    {
        /*************************************************************************************/

        //# Formatação com índices (interpolação)
        //INTERPOLAÇÃO

        Console.WriteLine($" {nome} tem {idade} anos e {saldo:F2} R$ na conta.");
        // variaveis dentro das chaves { }
        // Não esquecer de colocar o simbolo de cifrão no começo $ e antes das aspas 
        // :F2 serve para definir a quantidade de casas após a virgula de um double;
        // CONSOLE: Maria tem 30 anos e 250,65 R$ em conta.
        Console.WriteLine("**********************************\n");
        Console.WriteLine("PRESSIONE ENTER PRA CONTINUAR");
        Console.ReadKey(); //DEIXA O CURSOR AGUARDANDO O ENTER 
        Console.Clear();//LIMPA A TELA
    }

    static void Placeholders()
    {

        /*************************************************************************************/
        //# Formatação com índices (placeholders)

        Console.WriteLine("{0} tem {1} anos e {2:F2} R$ na conta.",nome, idade, saldo);
        // Não esquecer de colocar o indice da variavel dentro das chaves
        // depois da string (abre e fecha aspas), separa-se as variáveis com virgula
        // Mascaras { }
        // o indice é colocado conforme a sequencia das variáveis separadas por vírgulas
        //CONSOLE: Maria tem 30 anos e 250,65 R$ em conta.
        Console.WriteLine("**********************************\n");
        Console.WriteLine("PRESSIONE ENTER PRA CONTINUAR");
        Console.ReadKey(); //DEIXA O CURSOR AGUARDANDO O ENTER 
        Console.Clear();//LIMPA A TELA
        /*************************************************************************************/
    }

    static void AdicionarEspacoes()
    {  
        /*************************************************************************************/
        //# adicionando espacos

        //posso definir uma quantidade de espaços dentro da mascara
        Console.WriteLine("{0} tem {1,10} anos e {2:F2} R$ na conta. pao com mortadela",nome, idade, saldo);
        // O console irá imprimir mais 10 espaços antes do valor da variável
        //CONSOLE: Maria tem           30 anos e 250,65 R$ em conta.
        Console.WriteLine("**********************************\n");
        Console.WriteLine("PRESSIONE ENTER PRA CONTINUAR");
        Console.ReadKey(); //DEIXA O CURSOR AGUARDANDO O ENTER 
        Console.Clear();//LIMPA A TELA
        /*************************************************************************************/
    }

    static void FormatacaoMonetaria()
    {
        /*************************************************************************************/
        //# Formatação monetária
        //Posso colocar o valor monetario $, adicionando o :c
        Console.WriteLine(" {0} tem {1} anos e {2:c} na conta.", nome, idade, saldo);
        // O console irá imprimir $ antes do numero que tiver :c
        //CONSOLE: Maria tem 30 anos e 250,65 R$ na conta.
        Console.WriteLine("**********************************\n");
        Console.WriteLine("PRESSIONE ENTER PRA CONTINUAR");
        Console.ReadKey(); //DEIXA O CURSOR AGUARDANDO O ENTER 
        Console.Clear();//LIMPA A TELA
        /*************************************************************************************/
    }

    static void FormatacaoPorcentagem()
    {
        /*************************************************************************************/
        //# Formatação Porcentagem
        //Posso colocar o valor símbolo% adicionando o :c
        Console.WriteLine("{0} tem {1:p} anos e {2} na conta.", nome, idade, saldo);
        // O console irá imprimir $ antes do numero que tiver :c
        //CONSOLE: Maria tem 30 anos e 250,65 R$ na conta.
        Console.WriteLine("**********************************\n");
        Console.WriteLine("PRESSIONE ENTER PRA CONTINUAR");
        Console.ReadKey(); //DEIXA O CURSOR AGUARDANDO O ENTER 
        Console.Clear();//LIMPA A TELA
        /*************************************************************************************/
    }

    static void MenuFormatarStrings()
    {
        Console.Clear();
        Console.WriteLine("\tSELECIONE A DEMONSTRACAO: \n");
        Console.WriteLine("************************************************************\n");
        Console.WriteLine("Formatar Com Barra N e Barra t______________________DIGITE 1\n");
        Console.WriteLine("Formatar Com Interpolacao___________________________DIGITE 2\n");
        Console.WriteLine("Formatar Com Placeholders___________________________DIGITE 3\n");
        Console.WriteLine("Adicionar Espacoes__________________________________DIGITE 4\n");
        Console.WriteLine("Formatacao monetária________________________________DIGITE 5\n");
        Console.WriteLine("Formatar Com Porcentagem____________________________DIGITE 6\n");
        Console.WriteLine("Encerrar o programa_________________________________DIGITE 0\n");

        Console.WriteLine("************************************************************\n");

        int escolha = Convert.ToInt32(Console.ReadLine());

        switch (escolha)
        {
            case 1:                               
                Console.Clear();
                FormatarComBarraNeBarrat();                
                break;

            case 2:
                Console.Clear();
                Interpolacao();
                break;

            case 3:
                Console.Clear();
                Placeholders();                
                break;

            case 4:
                Console.Clear();
                AdicionarEspacoes();
                break;

            case 5:
                Console.Clear();
                FormatacaoMonetaria();                
                break;

            case 6:
                Console.Clear();
                FormatacaoPorcentagem();
                break;

            case 0:
                Console.Clear();
                Console.WriteLine("\tPROGRAMA FINALLIZADO! \nAPERTE ENTER E PARA SAIR!\n");
                Console.ReadLine();
                break;

            default:
                Console.WriteLine("\tOPCAO INVALIDA! \nAPERTE ENTER E SELECIONE UMA OPCAO NOVAMENTE!\n");
                Console.ReadLine();
                Console.Clear();
                MenuFormatarStrings();
                break;
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