
class program 
{
    static void Main()
    {
        //DESCRICAO
        Console.WriteLine("\n\t***VARIAVEIS***\n");

        //Declarar uma variável, significa criar a variável;
        //**Para declarar eu preciso digitar:**
        //< tipoDeDado > < nomeDaVariavel >;

        // NUMEROS INTEIROS
        int idade = 53;//declaração e atribuição da variavel int (32 bits);;
        short filhos = 14;//declaração e atribuição da variavel short (16 bits);
        long patrimonio = 419400000000;//declaração e atribuição de uma variavel long (16 bits, recebe um L maiusculo no final, por convenção);

        // NUMEROS QUEBRADOS
        float altura = 1.88f;//declaração e atribuição de uma variavel float (recebe um f minisculo no final, por convenção);
        double peso = 90.88;//declaração e atribuição de uma variavel double (recebe um f minisculo no final, por convenção);
        double peso2 = 90;//declaração e atribuição de uma variavel double (pode ser inteiro tambem);

        // DO TIPO TEXTO
        string nome = "Elon Musk";//declaração e atribuição de uma string;
        char sexo = 'M';

        // DO TIPO TEXTO GENERICA
        var qtdIrmaos = 2; // não posso mudar o tipo de var posteriormente, //a não ser que seja atribuindo
        var nomeIrmao1 = "Kimbal Musk";
        var nomeIrmao2 = "Tosca Musk";
        object qtdEmpresas = 6; // não posso mudar o tipo de var posteriormente, //a não ser que seja atribuindo
        object nomeEmpresas = "Tesla, SpaceX, Neuralink, The Boring Company, X (anteriormente Twitter), xAI";

        Console.WriteLine("\n***INFORMAÇÕES DO ELON MUSK***\n");
        Console.WriteLine("NOME: " +nome);
        Console.WriteLine("SEXO: " + sexo);
        Console.WriteLine("IDADE: " + idade);
        Console.WriteLine("FILHOS: " + filhos);
        Console.WriteLine("PATRIMÔNIO: " + patrimonio);
        Console.WriteLine("ALTURA: " + altura);
        Console.WriteLine("PESO: " + peso);
        Console.WriteLine("PESO TRUNCADO: " + peso2);
        Console.WriteLine("QUANTOS IRMAOS POSSUI: " + qtdIrmaos);
        Console.WriteLine("NOME IRMAO 1: " + nomeIrmao1);
        Console.WriteLine("NOME IRMAO 2: " + nomeIrmao2);
        Console.WriteLine("QUANTAS EMPRESAS POSSUI: " + qtdEmpresas);
        Console.WriteLine("NOME DAS EMPRESAS QUE POSSUI: " + nomeEmpresas);
    }

    static void ReiniciarPrograma()
    {
        Console.WriteLine("\nDeseja executar o programa novamente? [s/n]");

        string escolha = Console.ReadLine();

        switch (escolha)
        {
            case "s":
            case "S":
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


}





