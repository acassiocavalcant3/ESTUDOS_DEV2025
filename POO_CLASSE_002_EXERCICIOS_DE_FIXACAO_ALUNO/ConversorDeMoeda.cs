using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EXERCIOS_DE_FIXACAO_SOBRE_CLASSES
{
    /*    004 -  CONVERSOR DE MOEDA (CURSO UDEMY - NELIO ALVES)

Fazer um programa para ler a cotação do dólar e depois um valor em dólares a ser comprado por uma pessoa em reais.
Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda que a pessoa terá que pagar 6% de IOF
sobre o valor em dólar. Criar uma classe "ConversorDeMoeda" para ser responsável pelos calculos.
*/
    public class ConversorDeMoeda
    {
        public static double PorcentagemIof = 6;
        public static double CalcularCambio(double cotacao, double quantidadeDolares)
        {
            double valorCambial = (cotacao * quantidadeDolares);
            double imposto = ((PorcentagemIof/100) * valorCambial);
            double resultadoCambio = (valorCambial+imposto);
            return resultadoCambio;
        }
    }
}
