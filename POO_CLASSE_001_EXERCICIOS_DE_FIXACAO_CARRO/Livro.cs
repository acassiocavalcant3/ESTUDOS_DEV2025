using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_POO_2025
{
    /*  
    ## EXERCICIO002POO -  ALGORITMO CLASSE LIVRO (EXERCICIOS PROPOSTOS POR IA)

    Exercício 1: Sistema de Biblioteca
    Crie uma classe Livro com as seguintes propriedades:

    Título
    Autor
    Ano de publicação
    Disponível (booleano)
    
    Implemente os seguintes métodos:
    
    Emprestar(): muda o status para não disponível
    Devolver(): muda o status para disponível
    ExibirInformacoes(): mostra todos os dados do livro

    */

    public class Livro
    {
        public string? tituloLivro;
        public string? autorLivro;
        public int anoLivro;
        public bool disponibilidadeLivro = true;

        public void Emprestar()
        {
            disponibilidadeLivro = false;
        }
        public void Devolver()
        {
            disponibilidadeLivro = true;
        }

        public override string ToString()
        {
            string texto =

            $"\n************************************"
            + "\n______INFORMAÇÕES DO LIVRO_________"
            + "\n*************************************"
            + "\nTITULO:_______________________" + tituloLivro
            + "\nNOME DO AUTOR:________________" + autorLivro
            + "\nANO DE PUBLICACAO:____________" + anoLivro
            + "\nSTATUS LIVRO:_________________" + disponibilidadeLivro
            + "\n************************************";
            return texto;
        }
    }
}
