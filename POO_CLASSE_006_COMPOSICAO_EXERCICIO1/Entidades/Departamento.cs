using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_CLASSE_006_COMPOSICAO_EXERCICIO1.Entidades
{
    internal class Departamento
    {
        public string NomeDepartamento { get; set; }

        public Departamento()
        {            
        }
        public Departamento(string nomeDepartamento)
        {
            NomeDepartamento = nomeDepartamento;
        }

        public override string ToString()
        {
            string texto =

            $"\n************************************"
            + "\n______DADOS DO DEPARTAMENTO________"
            + "\n*************************************"
            + "\nNOME DO DEPARTAMENTO          ".PadRight(25) + NomeDepartamento
            + "\n************************************";
            return texto;
        }
    }
}
