//Diretivas using
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;


/*  
OPERADORES EM C#
### OPERADORES ARITMÉTICOS
adição + , subtração - , divisão / , multiplicação * , resto da divisão (módulo)  %

### OPERADORES INCREMENTAIS E DECREMENTAIS
++ aumenta 1 , decremento - - 1

### OPERADORES RELACIONAIS (retornam verdadeiro ou falso)
> maior que, < menor que, >= maior ou igual a, <= menor ou igual a, != diferente, == igual a

### OPERADORES LÓGICOS
AND/ E / && (retorna verdadeiro, quando TODAS condições forem verdades)
OR/ OU / || (retorna verdadeiro, quando UMA DAS condições forem verdades)
NOT/ NÃO/ ! (Inverte o valor lógico)

### OPERADORES DE ATRIBUIÇÃO CUMULATIVA
= atribui valor
+= (soma e atribui)  - TAMBEM SERVE PARA STRINGS (INCREMENTA)
-= (subtrai e atribui) (DECREMENTA)
*= (multiplica e atribui)
/= (divide e atribui)

# OPERADOR BITWISE
Também chamados de operador de shift, só serve para números inteiros
<<1  deslocamento para esquerda / dobra o valor da variável uma vez
>>1 deslocamento para a direita/ vira a metade do valor da variável

# OPERADORES TERNARIOS (vai ser abordado no algotimo condicional)
O operador ternário é composto por três operandos separados pelos sinais ? e : e tem o objetivo de atribuir o valor a uma variável de acordo com o resultado de um teste lógico. 
A sintaxe dele é: teste lógico ? valor se verdadeiro : valor se falso;

*/

class program
{

    static void Main(string[] args)
    {
    back1:
        //DESCRICAO DO ALGORITMO
        Console.WriteLine("\n\t***OPERADORES EM C#***\n");

        //### OPERADORES ARITMÉTICOS
        int a = 5, b = 10, c = 15, d = 20, e = 8, f = 34; // declaracao das quatro variáveis do tipo int
        int valor = 10, rendimento = 5;// declaracao das quatro variáveis do tipo int
        int num1 = 2, num2 = 4;// declaracao das quatro variáveis do tipo int

        //(a + d); operação de soma = 25
        //(c - a); operação de subtração = 10
        //(b * c); operação de multiplicação =150
        //(d / b); operação de divisão = 2
        //(c % b); operação de módulo (resto de divisão) =5

        Console.WriteLine("TESTANDO OPERADORES ARITIMETICOS: \n\nRESULTADO DO OPERADOR DE SOMA: {0}\nRESULTADO DO OPERADOR DE SUBTRACAO: {1}\nRESULTADO DO OPERADOR DE MULTIPLICACAO: {2} \nRESULTADO DO OPERADOR DE DIVISAO: {3}\nRESULTADO DO OPERADOR DE MODULO: {4}", (a + d), (c - a),(b * c), (d / b), (c % b));
        Console.WriteLine("**********************************\n");


        //### OPERADORES INCREMENTAIS E DECREMENTAIS
        // (e ++); incrementa a variavel e em 1 = 9
        // (f --); decrementa a variavel f em 1 = 33
        Console.WriteLine("TESTANDO OPERADORES INCREMENTAIS E DECREMENTAIS: \n\nRESULTADO DO OPERADOR INCREMENTO: {0}\nRESULTADO DO OPERADOR DE DECREMENTO: {1}", (e++), (f--));
        Console.WriteLine("**********************************\n");

        //### OPERADORES RELACIONAIS (retornam verdadeiro ou falso)
        // (a == d); avaliamos a igualdade entre a e d = FALSE
        // (b != c); avaliamos a desigualdade entre b e c = TRUE
        // (a > b);  avaliamos se a é maior que b = FALSE
        // (c < d);  avaliamos se c é menor que d = TRUE
        // (c >= a); avaliamos se c é maior ou igual que a = TRUE 
        // (d <= b); avaliamos se d é menor ou igual que b = FALSE
        Console.WriteLine("TESTANDO OPERADORES RELACIONAIS: \n\nRESULTADO DO OPERADOR DE IGUALDADE: {0}\nRESULTADO DO OPERADOR DE DIFERENCA: {1}\nRESULTADO DO OPERADOR MAIOR QUE: {2} \nRESULTADO DO OPERADOR MENOR QUE: {3}\nRESULTADO DO OPERADOR MAIOR OU IGUAL: {4} \nRESULTADO DO OPERADOR MENOR OU IGUAL: {5}", (a == d), (b != c), (a > b), (c > d), (c >= a), (d <= b));
        Console.WriteLine("**********************************\n");

        //### OPERADORES LOGICOS (retornam verdadeiro ou falso)
        // ((a != d) && (a < b)); AND/ E / && (retorna verdadeiro, quando TODAS condições forem verdades) = TRUE
        // ((b != c) || (a) == d   ); OR/ OU / || (retorna verdadeiro, quando UMA DAS condições forem verdades) = TRUE
        // !(a > b);  NOT/ NÃO/ ! (Inverte o valor lógico) = TRUE
        Console.WriteLine("TESTANDO OPERADORES LOGICOS: \n\nRESULTADO DO OPERADOR E (&&): {0}\nRESULTADO DO OPERADOR OU (||): {1}\nRESULTADO DO OPERADOR NOT (!): {2} "
        , ((a != d) && (a < b)), ((b != c) || (a) == d), !(a > b));
        Console.WriteLine("**********************************\n");

        //### OPERADORES DE ATRIBUIÇÃO CUMULATIVA
        //valor = 10 e rendimento = 5;
        valor += 1; // é o mesmo que valor RECEBE valor +1 (INCREMENTA) === RESULTADO:11
        Console.WriteLine("TESTANDO OPERADORES DE ATRIBUICAO CUMULATIVA:");
        Console.WriteLine("\nRESULTADO DO OPERADOR DE SOMA E ATRIBUIÇAO  'valor += 1...11' : {0}", valor);
        valor += rendimento;// === RESULTADO:16
        Console.WriteLine("RESULTADO DO OPERADOR DE SOMA E ATRIBUIÇAO  'valor += rendimento...16' : {0}", valor);
        //valor = 16 e rendimento = 5;
        valor -= 1; // é o mesmo que valor RECEBE valor -1 (DECREMENTA) === RESULTADO:15
        Console.WriteLine("RESULTADO DO OPERADOR DE SUBTRACAO E ATRIBUIÇAO  'valor -= 1...15' : {0}", valor);
        valor -= rendimento;// === RESULTADO:10
        Console.WriteLine("RESULTADO DO OPERADOR DE SUBTRACAO E ATRIBUIÇAO  'valor -= rendimento...10' : {0}", valor);
        //valor = 10 e rendimento = 5;
        valor *= 2; // é o mesmo que valor RECEBE valor *2  === RESULTADO:20
        Console.WriteLine("RESULTADO DO OPERADOR DE MULTIPLICACAO E ATRIBUIÇAO  'valor *= 2...20' : {0}", valor);
        valor *= rendimento;// === RESULTADO:100
        Console.WriteLine("RESULTADO DO OPERADOR DE SUBTRACAO E ATRIBUIÇAO  'valor *= rendimento...100' : {0}", valor);
        //valor = 100 e rendimento = 5;
        valor /= 2; // é o mesmo que valor RECEBE valor /2  === RESULTADO:50
        Console.WriteLine("RESULTADO DO OPERADOR DE MULTIPLICACAO E ATRIBUIÇAO  'valor /= 2...50' : {0}", valor);
        valor /= rendimento;// === RESULTADO:10
        Console.WriteLine("RESULTADO DO OPERADOR DE SUBTRACAO E ATRIBUIÇAO  'valor *= rendimento...10' : {0}", valor);
        Console.WriteLine("**********************************\n");

        //# OPERADOR BITWISE
        // num1 = 2;(bits 00000010)
        // num2 = 4;(bits 00000100)
        num1 = num1 << 1; //dobra o valor da variável uma vez/  dobro de 2 = 4   ;;;;;;;;;;;;;;;;(bits 00000010) << (bits 00000100)
        num2 = num2 << 2; //dobra o valor da variável duas vezes/ dobro de 4 = 8 = 16 ;;;;;;;;;;;(bits 00000100) << (bits 00010000)
        num1 = num1 >> 1; //divide por 2 o valor da variável uma vez/  metade de 2 = 1 ;;;;;;;;;;(bits 00000010) >> (bits 00000001)
        num2 = num2 >> 2; //divide por 2 o valor da variável duas vezes/ metade de 4 = 2 = 1 ;;;;(bits 00000100) >> (bits 00000001)
        Console.WriteLine("TESTANDO OPERADORES BITWISE: \n\nRESULTADO DO DESLOCAMENTOD DOS BITS PARA A ESQUERDA: {0}\nRESULTADO DO DO DESLOCAMENTOD DOS BITS PARA A DIREITA: {1}", num1 = num1 << 1, num2 = num2 >> 2);
        Console.WriteLine("**********************************\n");

        //LOOP DE EXECUCAO COM ROTULO
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
}