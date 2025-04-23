using System;
using System.Collections.Generic;

namespace POO_CLASSE_006_COMPOSICAO_EXERCICIO1.Entidades
{
    internal class ContratoDeHoras
    {
        public DateTime Data { get; set; }
        public double ValorPorHora { get; set; }
        public int HorasTrabalhadas { get; set; }

        public ContratoDeHoras()
        {
            
        }
        public ContratoDeHoras(DateTime data, double valorH, int horasT)
        {
            Data = data;
            ValorPorHora = valorH;
            HorasTrabalhadas = horasT;
        }

        public double GerarValorTotal()
        {
            double valorTotal = 0;

            valorTotal = ValorPorHora*HorasTrabalhadas;

            return valorTotal;
        }

        public override string ToString()
        {
            string texto =

            $"\n************************************"
            + "\n_________DADOS DO CONTRATO_________"
            + "\n*************************************"
            + "\nDATA:                         ".PadRight(25) + Data
            + "\nVALOR POR HORA:               ".PadRight(25) + ValorPorHora
            + "\nHORAS TRABALHADAS:            ".PadRight(25) + HorasTrabalhadas
            + "\n************************************";
            return texto;
        }
    }
}
