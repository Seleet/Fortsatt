public class Kurs
{
    public string KursNamn { get; set; }
    public DateOnly StartDatum { get; set; }
    public DateOnly SlutDatum { get; set; }
    public int Poäng { get; set; }

    public Kurs(string kursnamn, DateOnly startdatum, DateOnly slutdatum, int poäng)
    {
        KursNamn = kursnamn;
        StartDatum = startdatum;
        SlutDatum = slutdatum;
        Poäng = poäng;
    }

    private int BeraknaAntalKursDagarIntern() =>
        SlutDatum.DayNumber - StartDatum.DayNumber + 1;

    public int AntalKursdagar => BeraknaAntalKursDagarIntern();


    public float PoangPerKursdag()
    {
        return (float)Poäng / BeraknaAntalKursDagarIntern();
    }


}
