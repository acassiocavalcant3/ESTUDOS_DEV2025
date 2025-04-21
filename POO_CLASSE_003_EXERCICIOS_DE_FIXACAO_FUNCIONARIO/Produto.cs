using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CURSO_POO_NELIO_ALVES
{
    class Produto
    {
    //ATRIBUTOS PRIVADOS
        private string _nomeProduto;      

    //PROPRIEDADES AUTOIMPLEMENTADAS
        public double PrecoProduto { get; private set; }
        public int QuantidadeProduto { get; private set; }

    //CONSTRUTORES
        public Produto()//SOBRECARGA SEM PARAMETROS
        {
            
        }
        
        public Produto(string nome, Double preco)//SOBRECARGA 2 PARAMETROS
        {
            _nomeProduto = nome;
            PrecoProduto = preco;
            QuantidadeProduto = 0;//QUANTIDADE DEFAULT
        }
        public Produto(string nome, double preco, int quantidade)//SOBRECARGA 3 PARAMETROS
        {
            _nomeProduto = nome;
            PrecoProduto = preco;
            QuantidadeProduto = quantidade;
        }

    //PROPRIEDADES CUSTOMIZADAS
        public string NomeProduto
        {
            get
            {
                return _nomeProduto;
            }
            set
            {
                if ((value != null) && (value.Length > 1))
                {
                    _nomeProduto = value;
                }
            }
        }

    // OUTROS METODOS DA CLASSE
        public double ObterValorTotalEmEstoque()
        {
            double valorEstoque = PrecoProduto * QuantidadeProduto;

            return valorEstoque;
        }
        public void AdicionarProdutos(int quantidade)
        {
            QuantidadeProduto += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            QuantidadeProduto -= quantidade;
        }
        public override string ToString()
        {
            string texto =

            $"\n*****************************************************************"
            + "\n______________________DADOS DO PRODUTO___________________________"
            + "\n*****************************************************************"
            + "\nNOME DO PRODUTO:___________________________________________" + _nomeProduto
            + "\nVALOR DO PRODUTO:__________________________________________" + PrecoProduto.ToString("F2")
            + "\nQUANTIDADE DO PRODUTO:_____________________________________" + QuantidadeProduto
            + "\n*****************************************************************"
            + "\n*****************************************************************"
            + "\n***TOTAL $_________________________________________________" + ObterValorTotalEmEstoque().ToString("F2")
            + "\n*****************************************************************";
            return texto;
        }
    }
}


