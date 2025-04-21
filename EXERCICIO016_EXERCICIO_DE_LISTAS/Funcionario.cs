using System;

/*  
## EXERCICIO016 -  ALGORITMO FUNCIONARIO COM LIST (CURSO C# UDEMY - NELIO ALVES)

Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
N funcionários. Não deve haver repetição de id.
Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
conforme exemplos.
Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
aumento por porcentagem dada.

*/
namespace AulasCsharp2025
{
    class Funcionario
    {
        //ATRIBUTOS PRIVADOS
        private string _nome;
        private int _id;
        private decimal _salario;

        //PROPRIEDADES AUTOIMPLEMENTADAS

        //CONSTRUTORES
        public Funcionario(String nome, int id, decimal salario)
        {
            NomeFuncionario = nome;
            IdFuncionario = id;
            SalarioFuncionario = salario;
        }

        //PROPRIEDADES CUSTOMIZADAS
        public string NomeFuncionario
        {
            get { return _nome; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length > 2)
                {
                    _nome = value;
                }
            }
        }
        public int IdFuncionario
        {
            get { return _id; }
            set
            {
                if (value > 0 && value < 1000)
                {
                    _id = value;
                }
            }
        }
        public decimal SalarioFuncionario
        {
            get { return _salario; }
            set
            {
                if (value > 0 && value <= 100000)
                {
                    _salario = value;
                }
            }
        }

        // OUTROS METODOS DA CLASSE

        public void AumentarSalario(decimal porcentagem)
        {
            if (porcentagem > 0 && porcentagem <= 100)
            {
                decimal aumento = ((porcentagem / 100) * _salario);
                _salario += aumento;
            }
        }

        public override string ToString()
        {
            string dados1 = IdFuncionario.ToString().PadRight(10);//ID
            string dados2 = NomeFuncionario.ToString().PadRight(20);//NOME FUNCIONARIO
            string dados3 = SalarioFuncionario.ToString("C").PadRight(10);//SALARIO
            string texto = (dados1 + dados2 + dados3+ "\n");

            return texto;
        }
    }
}
