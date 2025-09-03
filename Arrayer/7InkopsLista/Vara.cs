namespace InkopsListaApp
{
    public class Vara
    {
        public string Namn { get; set; }
        public decimal Pris { get; set; }
        public int Produktnummer { get; set; }

        public Vara(string namn, decimal pris, int produktnummer)
        {
            Namn = namn;
            Pris = pris;
            Produktnummer = produktnummer;
        }
    }
}
