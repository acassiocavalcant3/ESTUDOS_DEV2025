//Diretivas using
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/*  
CRIANDO UM APP PARA SABER OS DADOS DO MEU SALARIO NA PREFEITURA MUNICIPAL
*/

class program
{

    //VALORES DE ENTRADA
    static double fg_Percentual = 0;
    static double salarioBase = 0;


    //TESTES LOGICOS
    //TESTES LOGICOS//ABONOS
    static bool decimoTerceiro_bool = false;
    static bool tercoDeFerias_bool = false;

    //CONSTANTES
    //CONSTANTES//VALORES REAIS
    const double salarioMinimoAtual2025 = 1518;

    //CONSTANTES//PERCENTUAIS
    const double pensaoPercentual = 0.75;
    const double previdenciaPercentual = 0.14;
    const double previdenciaPercentualInteiro = 14;
    //CONSTANTES//PERCENTUAIS//DIZIMO E OFERTA
    const double dizimoPercentual = 0.10;
    const double ofertaPercentual = 0.03;

    //CONSTANTES//EMPRESTIMOS
    const double emprestimo1 = 315.04;
    const double emprestimo2 = 287.23;
    const double emprestimo3 = 328.29;

    //CONSTANTES//RENDAS ALIQUOTA IR
    const double rendaIR1 = 2259.20;
    const double rendaIR2 = 2826.65;
    const double rendaIR3 = 3751.05;
    const double rendaIR4 = 4664.68;

    //CONSTANTES//DEDUCAO IR
    const double deducaoIR1 = 0.00;
    const double deducaoIR2 = 169.44;
    const double deducaoIR3 = 381.44;
    const double deducaoIR4 = 662.77;
    const double deducaoIR5 = 896.00;

    //VALORES PROCESSADOS
    //VALORES PROCESSADOS//DIZIMO E OFERTA
    static double dizimo_Valor = 0;
    static double oferta_Valor = 0;
    //VALORES PROCESSADOS//DESCONTOS E DESPESAS
    static double descontos_Valor = 0;
    static double despesas_Valor = 0;
    static double emprestimos_Valor = 0;
    static double pensao_Valor = 0;
    static double previdencia_Valor = 0;
    //VALORES PROCESSADOS//ABONOS
    static double decimoTerceiro_Valor = 0;
    static double fg_Valor = 0;
    static double tercoDeFerias_Valor = 0;
    //VALORES PROCESSADOS//VALORES FINAIS
    static double salarioBaseComFG_Valor = 0;
    static double salarioBruto_Valor = 0;
    static double salarioLiquido_Valor = 0;
    static double salarioLiquidoFinal_Valor = 0;

    //VALORES PROCESSADOS//IMPOSTO DE RENDA
    static double calculoBaseIR_Valor = 0;
    static double ir_Valor = 0;
    static double aliquotaIR_Valor = 0;
    static double aliquotaPercentual = 0;
    static double aliquotaPercentualInteiro = 0;
    static double impostoDeRenda_ValorFinal = 0;
    static double deducao_ValorFinal = 0;

    static void Main()
    {
        //DESCRICAO ALGORITIMOS MEU SALARIO PREFEITURA 
        Console.WriteLine("******************************************************");
        Console.WriteLine("\n\t***APLICATIVO MINHA RENDA PREFEITURA***\n");

        //METODOS DE ENTRADA
        PerguntarSalarioEfg();
        PerguntarFeriasEDecimo();
        //METODOS DE PROCESSAMENTO        
        //METODOS DE PROCESSAMENTO//ABONOS
        CalcularFG();
        CalcularFerias();
        CalcularDecimo();
        CalcularSalarioBruto();
        //METODOS DE PROCESSAMENTO//DESCONTOS
        CalcularPensao();
        CalcularPrevidencia();        
        CalcularCalculoBaseIR();
        CalcularAliquotaEDeducao();
        CalcularOValorDaAliquotaIR();
        CalcularImpostoDeRendaFinal();
        CalcularDescontos();
        ////METODOS DE PROCESSAMENTO//DESPESAS
        CalcularSalarioLiquido();
        CalcularEmprestimos();          
        CalcularDespesas();
        CalcularDizimoEOferta();
        CalcularSalarioLiquidoFinal(); 
        ////METODOS DE PROCESSAMENTO//
        
        
        //METODOS DE SAIDA
        MostrarValoresDeEntrada();
        MostrarAbonos();
        MostrarDescontos();
        MostrarValoresFinais();


        //MostrarTestes();
        

        //METODOS DE SUPORTE
        ReiniciarPrograma();
    }




    //METODOS DE ENTRADA
    static void PerguntarSalarioEfg()
    {
        Console.WriteLine("******************************************************");
        Console.Write("DIGITE O SEU SALÁRIO BASE: (R$) ");
        salarioBase = Convert.ToDouble(Console.ReadLine());
        Console.Write("DIGITE O SEU FG (0 - 100): (%)  ");
        fg_Percentual = Convert.ToDouble(Console.ReadLine());
    }
    static void PerguntarFeriasEDecimo()
    {
        Console.Clear();
        Console.WriteLine("******************************************************");
        Console.WriteLine("\nDeseja incluir 13 e/ou ferias nos calculos? [s/n]");
        string escolha = Console.ReadLine();

        switch (escolha)
        {
            case "s":
            case "S":
                MenuFeriasEdecimo();
                break;

            case "n":
            case "N":
                break;

            default:
                Console.WriteLine("******************************************************");
                Console.WriteLine("\tOPCAO INVALIDA! \nAPERTE ENTER E SELECIONE UMA OPCAO NOVAMENTE!\n");
                Console.ReadLine();
                Console.Clear();
                PerguntarFeriasEDecimo();
                break;
        }        
    }
    static void MenuFeriasEdecimo()
    {
        Console.Clear();
        Console.WriteLine("\tSELECIONE O QUE DESEJA INCLUIR NOS CALCULOS\n");
        Console.WriteLine("*********************************************\n");
        Console.WriteLine("DECIMO TERCEIRO______________________DIGITE 1\n");
        Console.WriteLine("FERIAS_______________________________DIGITE 2\n");
        Console.WriteLine("FERIAS E DECIMO TERCEIRO_____________DIGITE 3\n");
        Console.WriteLine("NAO CALCULAR_________________________DIGITE 4\n");
        Console.WriteLine("*********************************************\n");

        int escolha = Convert.ToInt32(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                decimoTerceiro_bool = true;
                Console.Clear();
                break;

            case 2:
                tercoDeFerias_bool = true;
                Console.Clear();
                break;

            case 3:
                tercoDeFerias_bool = true;
                decimoTerceiro_bool = true;
                Console.Clear();
                break;

            case 4:
                tercoDeFerias_bool = false;
                decimoTerceiro_bool = false;
                Console.Clear();
                break;

            default:
                Console.WriteLine("\tOPCAO INVALIDA! \nAPERTE ENTER E SELECIONE UMA OPCAO NOVAMENTE!\n");
                Console.ReadLine();
                Console.Clear();
                MenuFeriasEdecimo();
                break;
        }
    }


    //METODOS DE PROCESSAMENTO//SALARIO BRUTO
    static void CalcularSalarioBruto()
    {
        salarioBruto_Valor = (salarioBase + fg_Valor + tercoDeFerias_Valor + decimoTerceiro_Valor);
    }
    //METODOS DE PROCESSAMENTO//ABONOS
    static void CalcularFG()
    {
        fg_Valor = salarioBase * (fg_Percentual / 100);
    }
    static void CalcularFerias()
    {
        if (tercoDeFerias_bool == true)
        {

            tercoDeFerias_Valor = ((salarioBase + fg_Valor) / 3);
        }
        else
        {
            tercoDeFerias_Valor = 0;
        }
    }
    static void CalcularDecimo()
    {
        if (decimoTerceiro_bool == true)
        {

            decimoTerceiro_Valor = ((salarioBase + fg_Valor));
        }
        else
        {
            decimoTerceiro_Valor = 0;
        }
    }

    //METODOS DE PROCESSAMENTO//DESCONTOS  
    static void CalcularPrevidencia()
    {
        if (decimoTerceiro_bool == true)
        {

            previdencia_Valor = ((salarioBase * previdenciaPercentual) * 2);

        }
        else
        {
            previdencia_Valor = (salarioBase * previdenciaPercentual);
        }
    }

    //METODOS DE PROCESSAMENTO//DESCONTOS//IMPOSTO DE RENDA
    static void CalcularCalculoBaseIR()
    {
        salarioBaseComFG_Valor = (salarioBase + fg_Valor);

        if (tercoDeFerias_bool==true)
        {
            calculoBaseIR_Valor = ((salarioBaseComFG_Valor - previdencia_Valor) - pensao_Valor);
        }
        else
        {
            calculoBaseIR_Valor = ((salarioBaseComFG_Valor - previdencia_Valor) - pensao_Valor);
        }
    }
    static void CalcularAliquotaEDeducao()
    {
        if (calculoBaseIR_Valor <= rendaIR1)
        //Calculo base menor ou igual a R$ 2.259,20 ==> aliquota 0%//deducao R$ 0.00

        {
            aliquotaPercentual = 0;
            aliquotaPercentualInteiro = 0;
            deducao_ValorFinal = deducaoIR1;
        }
        else if ((calculoBaseIR_Valor > rendaIR1) && (calculoBaseIR_Valor <= rendaIR2))
        //Calculo base for maior que R$ 2.259,20 e menor que R$ 2.826,65 ==> aliquota 0.075%//R$ 169.44 
        {
            aliquotaPercentual = 0.075;
            aliquotaPercentualInteiro = 7.5;
            deducao_ValorFinal = deducaoIR2;
        }
        else if ((calculoBaseIR_Valor > rendaIR2) && (calculoBaseIR_Valor <= rendaIR3))
        //Calculo base for maior que R$ 2.826,65 e menor que R$ 3.751,05 ==> aliquota 0.15%//R$ 381.44
        {
            aliquotaPercentual = 0.15;
            aliquotaPercentualInteiro = 15;
            deducao_ValorFinal = deducaoIR3;
        }
        else if ((calculoBaseIR_Valor > rendaIR3) && (calculoBaseIR_Valor <= rendaIR4))
        //Calculo base for maior que R$ 3.751,05 e menor que R$ 4.664,68 ==> aliquota 0.225%//R$ 662.77
        {
            aliquotaPercentual = 0.225;
            aliquotaPercentualInteiro = 22.5;
            deducao_ValorFinal = deducaoIR4;
        }
        else
        //se o calculo base for maior que R$ 3.751,05 e menor que R$ 4.664,68 ==> aliquota 0.15%//R$ 381.44
        {
            aliquotaPercentual = 0.275;
            aliquotaPercentualInteiro = 27.5;
            deducao_ValorFinal = deducaoIR5;
        }
    }
    static void CalcularOValorDaAliquotaIR()
    {
        aliquotaIR_Valor = (calculoBaseIR_Valor * aliquotaPercentual);
    }
    static void CalcularImpostoDeRendaFinal()
    {
        ir_Valor = (aliquotaIR_Valor - deducao_ValorFinal);

        if (decimoTerceiro_bool == true)
        {

            impostoDeRenda_ValorFinal = (ir_Valor * 2);

        }
        else
        {
            impostoDeRenda_ValorFinal = (ir_Valor);
        }
    }


    //METODOS DE PROCESSAMENTO//DESPESAS
    static void CalcularDizimoEOferta()
    {
        dizimo_Valor = (salarioLiquido_Valor * dizimoPercentual);
        oferta_Valor = (salarioLiquido_Valor * ofertaPercentual);


    }
    static void CalcularPensao()
    {
        pensao_Valor = salarioMinimoAtual2025 * pensaoPercentual;
    }


    //METODOS DE PROCESSAMENTO//VALORES FINAIS
    static void CalcularSalarioLiquido()
    {
        salarioLiquido_Valor = (salarioBruto_Valor - descontos_Valor);
    }
    static void CalcularSalarioLiquidoFinal()
    {
        salarioLiquidoFinal_Valor = (salarioLiquido_Valor - despesas_Valor);
    }
    static void CalcularEmprestimos()
    {
        emprestimos_Valor = (emprestimo1 + emprestimo2 + emprestimo3);
    }
    static void CalcularDescontos()
    {
        descontos_Valor = (previdencia_Valor + impostoDeRenda_ValorFinal);

    }
    static void CalcularDespesas()
    {
        despesas_Valor = (pensao_Valor + emprestimos_Valor);

    }


    //METODOS DE SAIDA// RESULTADOS (SAIDAS)
    static void MostrarValoresDeEntrada()
    {
        Console.Clear();
        Console.WriteLine("******************************************************");
        Console.WriteLine("________________VALORES DE ENTRADA____________________");
        Console.WriteLine("******************************************************");
        Console.WriteLine("***SALARIO BASE:_________________________  {0:c}", salarioBase);
        Console.WriteLine("***GRATIFICACAO:_________________________     {0}%", fg_Percentual);
        Console.WriteLine("******************************************************");

        Console.Write("\nTecle enter continuar...");
        Console.ReadLine();
    }
    static void MostrarAbonos()
    {
        Console.Clear();
        Console.WriteLine("*****************************************************");
        Console.WriteLine("_____________________ABONOS________________________\n");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("***VALOR GRATIFICACAO:___________________ {1:c} -- (FG {0}%)", fg_Percentual, fg_Valor);
        Console.WriteLine("***1/3 DE FERIAS:________________________ {0:c}", tercoDeFerias_Valor);
        Console.WriteLine("***DECIMO TERCEIRO:______________________ {0:c}", decimoTerceiro_Valor);
        Console.WriteLine("*****************************************************");

        Console.Write("\nTecle enter continuar...");
        Console.ReadLine();
    }
    static void MostrarDescontos()
    {
        Console.Clear();
        Console.WriteLine("*****************************************************");
        Console.WriteLine("_____________________DESCONTOS_____________________\n");
        Console.WriteLine("*****************************************************");
        Console.WriteLine("***EMPRESTIMOS:___________________ {0:c}", emprestimos_Valor);
        Console.WriteLine("***PENSAO:________________________ {0:c}", pensao_Valor);
        Console.WriteLine("***IMPOSTO DE RENDA:______________ {1:c} ------ (ALIQUOTA {0}%)", aliquotaPercentualInteiro, impostoDeRenda_ValorFinal);
        Console.WriteLine("***PREVIDENCIA:___________________ {1:c} ------ (ALIQUOTA {0}%)", previdenciaPercentualInteiro, previdencia_Valor);
        Console.WriteLine("\n***************************************************");

        Console.Write("\nTecle enter continuar...");
        Console.ReadLine();
    }
    static void MostrarValoresFinais()
    {

        Console.Clear();
        Console.WriteLine("******************************************************");
        Console.WriteLine("________________RESULTADO FINAL:______________________\n");
        Console.WriteLine("******************************************************");
        Console.WriteLine("***SALARIO BRUTO:_______________________________  {0:c}", salarioBruto_Valor);
        Console.WriteLine("***DESCONTOS:___________________________________  {0:c}", descontos_Valor);
        Console.WriteLine("***SALARIO (-IR e Previdencia):_________________  {0:c}", salarioLiquido_Valor);
        Console.WriteLine("***SALARIO LIQUIDO _____________________________  {0:c}", salarioLiquidoFinal_Valor);
        Console.WriteLine("******************************************************");
        Console.WriteLine("***DIZIMO:_______________________________  {0:c}", dizimo_Valor);
        Console.WriteLine("***OFERTA:_______________________________  {0:c}", oferta_Valor);
        Console.WriteLine("******************************************************");

        Console.Write("\nTecle enter continuar... \n");
        Console.ReadLine();
    }

    //METODOS DE SUPORTE//
    //METODOS DE SUPORTE// TESTES
    static void MostrarTestes()
    {
        Console.Clear();
        Console.WriteLine("*****************************************************\n");
        Console.WriteLine("fg_Percentual:______________________  {0}%", fg_Percentual);       
        Console.WriteLine("salarioBase:________________________  {0:c}", salarioBase);
        Console.WriteLine("decimoTerceiro_bool:________________  {0}", decimoTerceiro_bool);
        Console.WriteLine("tercoDeFerias_bool:_________________  {0}", tercoDeFerias_bool);
        Console.WriteLine("dizimo_Valor:_______________________  {0:c}  __", dizimo_Valor);
        Console.WriteLine("oferta_Valor:_______________________  {0:c}", oferta_Valor);
        Console.WriteLine("descontos_Valor:____________________  {0:c}", descontos_Valor);
        Console.WriteLine("despesas_Valor:_____________________  {0:c}", despesas_Valor);
        Console.WriteLine("emprestimos_Valor:__________________  {0:c}", emprestimos_Valor);
        Console.WriteLine("pensao_Valor:_______________________  {0:c}", pensao_Valor);
        Console.WriteLine("previdencia_Valor:__________________  {0:c}", previdencia_Valor);
        Console.WriteLine("decimoTerceiro_Valor:_______________  {0:c}", decimoTerceiro_Valor);
        Console.WriteLine("fg_Valor:___________________________  {0:c}", fg_Valor);
        Console.WriteLine("tercoDeFerias_Valor:________________  {0:c}", tercoDeFerias_Valor);
        Console.WriteLine("salarioBaseComFG_Valor:_____________  {0:c}", salarioBaseComFG_Valor);
        Console.WriteLine("salarioBruto_Valor:_________________  {0:c}", salarioBruto_Valor);
        Console.WriteLine("salarioLiquido_Valor:_______________  {0:c}", salarioLiquido_Valor);
        Console.WriteLine("salarioLiquidoFinal_Valor:__________  {0:c}", salarioLiquidoFinal_Valor);
        Console.WriteLine("calculoBaseIR_Valor:________________  {0:c}", calculoBaseIR_Valor);
        Console.WriteLine("ir_Valor:___________________________  {0:c}", ir_Valor);
        Console.WriteLine("aliquotaIR_Valor:___________________  {0:c}", aliquotaIR_Valor);    
        Console.WriteLine("aliquotaPercentual:_________________  {0}%", aliquotaPercentual);  
        Console.WriteLine("aliquotaPercentualInteiro:__________  {0}%", aliquotaPercentualInteiro);
        Console.WriteLine("impostoDeRenda_ValorFinal:__________  {0:c}", impostoDeRenda_ValorFinal);
        Console.WriteLine("deducao_ValorFinal:_________________  {0:c}", deducao_ValorFinal);
    }
    //METODOS DE SUPORTE// REINICIAR O PROGRAMA
    static void ReiniciarPrograma()
    {
        //REINICIAR PROGRAMA
        Console.WriteLine("******************************************************");
        Console.WriteLine("\nDeseja executar o programa novamente? [s/n]");

        string escolha = Console.ReadLine();

        switch (escolha)
        {
            case "s":
            case "S":                
                ReiniciarVariaveis();
                Main();
                break;

            case "n":
            case "N":
                break;

            default:
                Console.WriteLine("******************************************************");
                Console.WriteLine("\tOPCAO INVALIDA! \nAPERTE ENTER E SELECIONE UMA OPCAO NOVAMENTE!\n");
                Console.ReadLine();
                Console.Clear();
                ReiniciarPrograma();
                break;
        }
    }
    //METODOS DE SUPORTE// REINICIAR VARIAVEIS
    static void ReiniciarVariaveis()
    {
        
        fg_Percentual = 0;
        salarioBase = 0;        
        decimoTerceiro_bool = false;
        tercoDeFerias_bool = false;    
        dizimo_Valor = 0;
        oferta_Valor = 0;        
        descontos_Valor = 0;
        despesas_Valor = 0;
        emprestimos_Valor = 0;
        pensao_Valor = 0;
        previdencia_Valor = 0;        
        decimoTerceiro_Valor = 0;
        fg_Valor = 0;
        tercoDeFerias_Valor = 0;        
        salarioBaseComFG_Valor = 0;
        salarioBruto_Valor = 0;
        salarioLiquido_Valor = 0;
        salarioLiquidoFinal_Valor = 0;        
        calculoBaseIR_Valor = 0;
        ir_Valor = 0;
        aliquotaIR_Valor = 0;
        aliquotaPercentual = 0;
        aliquotaPercentualInteiro = 0;
        impostoDeRenda_ValorFinal = 0;
        deducao_ValorFinal = 0;
        Console.Clear();
    }
}
