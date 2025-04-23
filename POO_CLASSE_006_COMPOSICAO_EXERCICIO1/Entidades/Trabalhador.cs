using System;
using System.Collections.Generic;
using POO_CLASSE_006_COMPOSICAO_EXERCICIO1.Entidades.Enums;

namespace POO_CLASSE_006_COMPOSICAO_EXERCICIO1.Entidades
{
    internal class Trabalhador
    {
        //ATRIBUTOS PRIVADOS

        //PROPRIEDADES AUTOIMPLEMENTADAS
        public string? Nome { get; set; }
        public NivelDoTrabalhador Nivel { get; set; }//PROPRIEDADE DO TIPO ENUM
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }//COMPOSICAO DA CLASSE DEPARTAMENTO (TRABALHADOR TEM 1 DEPARTAMENTO)
        public List<ContratoDeHoras> ListaDeContratos { get; set; } = new List<ContratoDeHoras>();//COMPOSICAO DA CLASSE CONTRATOS(TRABALHADOR TEM VARIOS CONTRATOS)

        //CONSTRUTORES        
        public Trabalhador()
        {

        }
        public Trabalhador(string nome, NivelDoTrabalhador classificacao, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = classificacao;
            SalarioBase = salarioBase;
            Departamento = departamento;
            //NAO ADICIONA A LISTA NO CONSTRUTOR (1 PARA VARIOS)
        }

        //PROPRIEDADES CUSTOMIZADAS

        // OUTROS METODOS DA CLASSE
        public void AdicionarContrato(ContratoDeHoras contrato)//RECEBE UM OBJETO DA CLASSE CONTRATO DE HORAS
        {
            ListaDeContratos.Add(contrato);
        }
        public void RemoverContrato(ContratoDeHoras contrato)
        {
            ListaDeContratos.Remove(contrato);
        }
        public double DefinirSalarioFinal(int ano, int mes)
        {            
            double salarioFinal = SalarioBase;//JA INICIA COM O VALOR DO SALARIO BASE

            foreach (ContratoDeHoras contrato in ListaDeContratos)//
            {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    salarioFinal += contrato.GerarValorTotal();
                }
            }
            return salarioFinal;
        }

        public override string ToString()
        {
            string texto =

            $"\n************************************"
            + "\n_______DADOS DO TRABALHADOR________"
            + "\n*************************************"
            + "\nNOME:                         ".PadRight(25) + Nome
            + "\nNIVEL:                        ".PadRight(25) + Nivel
            + "\nSALARIO BASE:                 ".PadRight(25) + SalarioBase.ToString("F2")
            + "\nDEPARTAMENTO:                 ".PadRight(25) + Departamento.NomeDepartamento
            + "\n************************************";
            return texto;
        }
    }
}
