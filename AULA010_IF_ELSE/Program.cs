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
# OPERADORES TERNÁRIOS (condicional)

O operador ternário é composto por três operandos separados pelos sinais ? e : e tem o objetivo de atribuir o valor a uma variável de acordo com o resultado de um teste lógico. 

A sintaxe dele é: <teste lógico> ? <valor se verdadeiro> : <valor se falso>;
É tipo um if/else reduzido.  Os argumentos antes do ? é a condição (se). o ? é o então. O : é o senão 
*/

namespace AulasCsharp2025
{
    class program
    {

        static int nota1, nota2, nota3, nota4;
        static double media = 0;
        const int notaDeCorte = 70;

        static void Main()
        {
        back1:
            //DESCRICAO OPERADORES TERNARIOS (ESTRUTURA CONDICIONAL)
            Console.WriteLine("\n\t***IF E ELSE - MEDIA ESCOLAR***\n");
            Console.WriteLine("DIGITE A NOTA DO 1º BIMESTRE: ");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE A NOTA DO 2º BIMESTRE: ");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE A NOTA DO 3º BIMESTRE: ");
            nota3 = int.Parse(Console.ReadLine());
            Console.WriteLine("DIGITE A NOTA DO 4º BIMESTRE: ");
            nota4 = int.Parse(Console.ReadLine());

            media = ((nota1 + nota2 + nota3 + nota4) / 4);

            Console.WriteLine(media >= notaDeCorte ? "Aluno provado! " : "Aluno reprovado! ");


            if (media < 50)//condição 
            {
                Console.WriteLine("Aluno reprovado! ");
                Console.WriteLine($"Sua Media foi: {media}");
            }
            else if (media >= 50 && media < 70)
            {
                Console.WriteLine("Ficou de Recuperacao! ");
                Console.WriteLine($"Sua Media foi: {media}");
            }
            else
            {
                Console.WriteLine("Parabens! voce foi aprovado! ");
                Console.WriteLine($"Sua Media foi: {media}");
            }


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
}
