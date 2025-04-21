using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace EXERCIOS_DE_FIXACAO_SOBRE_CLASSES
{
    public class Aluno
    {
        
        public string? Nome;
        public double NotaFinal; 
        public double NotaDeCorte = 60; 
        public bool Aprovado;

        public Aluno(string nome)
        {
            Nome = nome;
        }
    

        public void CalcularNotaFinal(double nota1, double nota2, double nota3)
        {            
            NotaFinal = (nota1+nota2+nota3);            
        }
        public void ChecarAprovacao()
        {
            Aprovado = ((NotaFinal >= NotaDeCorte) ? Aprovado = true : Aprovado = false);
        }       
        public double ChecarNotasRestantes()
        {
            double notasRestantes = Aprovado? 0.00 : Math.Abs(NotaFinal-NotaDeCorte); 
            return notasRestantes;
        }  


        public override string ToString()
        {
            ChecarAprovacao();
            string status = Aprovado? status = "APROVADO": status = $"REPROVADO\nFALTARAM {ChecarNotasRestantes():F2} PONTOS";
            string infoAluno = $"\nDADOS DO ALUNO \nNOME: {Nome} \nNOTA FINAL: {NotaFinal:F2} \n{status}";
            return infoAluno;
        }
    }
}
 