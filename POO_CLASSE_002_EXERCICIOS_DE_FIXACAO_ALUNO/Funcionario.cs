using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCIOS_DE_FIXACAO_SOBRE_CLASSES
{
    class Funcionario
    {

        public string? Nome;
        public double SalarioBruto; 
        public double Imposto;    

        public Funcionario(string nome, double salarioBruto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
        }

        public double CalcularSalarioLiquido()
        {
            double salarioLiquido = SalarioBruto - Imposto;

            return salarioLiquido;
        }
        public void AumentarSalario(double porcentagem)
        {
            double aumento = SalarioBruto * (porcentagem / 100);
            SalarioBruto += aumento;
        }
        
        public override string ToString()
        {
            string infoFuncionario = $"\nDADOS DO FUNCIONARIO \nNOME: {Nome} \nSALARIO LIQUIDO: R$ {CalcularSalarioLiquido():c} ";
            return infoFuncionario;
        }   
    }
}
