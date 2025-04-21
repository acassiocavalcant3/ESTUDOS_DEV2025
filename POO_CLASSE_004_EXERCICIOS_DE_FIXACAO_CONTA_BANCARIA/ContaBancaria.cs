using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CURSO_POO_NELIO_ALVES;
public class ContaBancaria
{
    //ATRIBUTOS PRIVADOS
    private string _nomeTitular;
    private int _numeroConta;
    private decimal _saldo;

    //PROPRIEDADES AUTOIMPLEMENTADAS
    public int NumeroConta { get; set; }
    public decimal SaldoConta { get; private set; }

    //CONSTRUTORES
    public ContaBancaria(int numeroDaConta, string nomeCliente, decimal depositoInicial)
    {
        NumeroConta = numeroDaConta;
        NomeTitular = nomeCliente;
        Depositar(depositoInicial);
    }
    public ContaBancaria(int numeroDaConta, string nomeCliente)
    {
        NomeTitular = nomeCliente;
        NumeroConta = numeroDaConta;
    }

    //PROPRIEDADES CUSTOMIZADAS
    public string NomeTitular
    {
        get { return _nomeTitular; }
        set
        {
            int quantidadeDeCaracteres = 2;
            if ((value != null) && (value.Length > quantidadeDeCaracteres ))
            {
                _nomeTitular = value;
            }
            else
            {
                Console.WriteLine($"Nome deve ter mais que {quantidadeDeCaracteres} caracteres");
            }
        }
    }

    // OUTROS METODOS DA CLASSE
    public static bool ChecarDepositoInicial(string escolha)
    {
        bool decisao;

        if ((escolha == "S") || (escolha == "s"))
        {
            decisao = true;
        }
        else
        {
            decisao = false;
        }

        return decisao;
    }

    public void Depositar(decimal dinheiro)
    {
        if (dinheiro > 0)
        {
            SaldoConta += dinheiro;
        }
    }

    public void Sacar(decimal dinheiro)
    {        
        decimal taxa = 5;
        if (dinheiro <= (SaldoConta-taxa))
        {
            SaldoConta -= taxa;
            SaldoConta -= dinheiro;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente!");
        }

    }

    public override string ToString()
    {
        string texto =

        $"\n************************************"
        + "\n______DADOS DA CONTA BANCARIA______"
        + "\n*************************************"
        + "\nNUMERO DA CONTA:______________" + NumeroConta
        + "\nTITULAR DA CONTA:_____________" + NomeTitular
        + "\nSALDO BANCARIO:_______________R$ " + SaldoConta.ToString("F2")
        + "\n************************************";
        return texto;
    }
}
