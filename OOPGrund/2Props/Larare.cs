public class Larare
{
    public string Förnamn { get; set; }
    public string Efternamn { get; set; }
    public string Email { get; set; }
    public string Telefon { get; set; }

    // Offentlig metod som anropar den privata metoden
    public List<Kurs> AnsvarigForKurser()
    {
        return HamtaKurser();
    }

    // Privat metod med exempeldata


    private List<Kurs> HamtaKurser()
    {
        return new List<Kurs>
    {
        new Kurs("Programmering C#", new DateOnly(2025, 1, 10), new DateOnly(2025, 3, 10), 100),
        new Kurs("ASP.NET med C#", new DateOnly(2025, 3, 15), new DateOnly(2025, 5, 15), 100),
        new Kurs("Frontend utveckling", new DateOnly(2025, 8, 20), new DateOnly(2025, 10, 20), 100)
    };
    }

}
