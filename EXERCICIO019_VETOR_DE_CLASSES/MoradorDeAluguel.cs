namespace AulasCsharp2025
{
    class MoradorDeAluguel
    {
        public string NomeInquilino { get; set; }
        public string EmailInquilino { get; set; }


        public MoradorDeAluguel(string nomeInquilino, string emailInquilino)
        {
            NomeInquilino = nomeInquilino;
            EmailInquilino = emailInquilino;
        }


        public override string ToString()
    {
        string texto =

        $"\n**************************************************"
        + "\nNOME DO MORADOR:____________" + NomeInquilino
        + "\nEMAIL DO MORADOR:___________" + EmailInquilino
        + "\n*************************************************";
        return texto;
    }
    }
}