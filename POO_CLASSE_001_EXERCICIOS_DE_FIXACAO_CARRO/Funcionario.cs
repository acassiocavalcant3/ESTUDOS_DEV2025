using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_POO_2025
{
    /*  
    ## EXERCICIO003POO -  ALGORITMO CLASSE CONTA BANCARIA (EXERCICIOS PROPOSTOS POR IA)

    Crie uma classe ContaBancaria com:

    Número da conta
    Nome do titular
    Saldo

    Implemente os seguintes métodos:

    Depositar(double valor): adiciona o valor ao saldo
    Sacar(double valor): subtrai o valor do saldo se houver saldo suficiente
    VerificarSaldo(): retorna o saldo atual
    ExibirDados(): mostra todos os dados da conta

    */
    public class Funcionario
    {
        public string? _nomeFuncionario;
        public string? _cargo;
        public decimal _salarioBase;

        public decimal CalcularSalario()
        {
            //decimal previdencia = 0.14m;
            //decimal desconto = (_salarioBase*previdencia);
            decimal desconto = 100m;
            _salarioBase -= desconto;
            return _salarioBase;
        }
        
        public override string ToString()
        {
            string texto =

            $"\n************************************"
            + "\n____________HOLERITE_______________"
            + "\n***********************************"
            + "\nNOME FUNCIONARIO:_____________" + _nomeFuncionario
            + "\nCARGO FUNCIONARIO:____________" + _cargo
            + "\nSALARIO BASE:_________________" + _salarioBase
            + "\n************************************";
            return texto;
        }

    }
}
