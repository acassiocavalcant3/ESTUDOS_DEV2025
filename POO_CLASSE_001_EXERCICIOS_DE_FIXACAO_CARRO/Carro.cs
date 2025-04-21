using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_POO_2025
{
    /*  
    ## EXERCICIO001POO -  ALGORITMO CLASSE CARRO (EXERCICIOS PROPOSTOS POR IA)

    1. Crie uma classe chamada **Carro** com os atributos: `modelo`, `ano` e `cor`.
    2. Adicione um método chamado **Dirigir()** que imprime: "O carro está em movimento".
    3. Crie dois objetos da classe Carro com valores diferentes e chame o método `Dirigir()`.

    */
    public class Carro
    {
        public string? nomeDono;
        public string? modelo;
        public int ano;
        public string? cor;

        public void Dirigir()
        {
            Console.WriteLine("O carro está em movimento");
        }

        public override string ToString()
    {
        string texto =

        $"\n************************************"
        + "\n______DOCUMENTO DO CARRO___________"
        + "\n*************************************"
        + "\nDONO DO CARRO:________________" + nomeDono
        + "\nMODELO DO CARRO:______________" + modelo
        + "\nCOR DO CARRO:_________________" + cor
        + "\nANO DO CARRO:_________________" + ano
        + "\n************************************";
        return texto;
    }
    }
}
