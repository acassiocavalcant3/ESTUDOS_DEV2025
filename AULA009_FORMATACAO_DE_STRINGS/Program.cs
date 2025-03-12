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

    static void Main(string[] args)
    {
    back1:
        //DESCRICAO ALGOTIMOS COM TECNICAS PARA FORMATAR STRINGS
        Console.WriteLine("\n\t***FORMATACAO DE STRINGS***\n");



        //FormatarComBarraNeBarrat();
        //Interpolacao();
        //Placeholders();
        //AdicionarEspacoes();
        //FormatacaoMonetaria();
        FormatacaoPorcentagem();


        Console.WriteLine("\nDeseja executar novamente? [s/n]");
        char escolha = char.Parse(Console.ReadLine());
        if (escolha == 'S' || escolha == 's')
        {
            Console.Clear();
            goto back1;
        }
        else
        {
            Console.Clear();
            Console.WriteLine("\nFim da execução. Tecle enter para sair... \n");
            Console.ReadLine();
        }
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


}