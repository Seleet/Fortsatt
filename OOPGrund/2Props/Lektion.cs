public class Lektion
{
    public string Kurs { get; set; }
    public DateOnly Datum { get; set; }
    public string Klassrum { get; set; }

    // Returnerar true om alla properties är satta
    public bool Boka()
    {
        return !string.IsNullOrWhiteSpace(Kurs)
            && Datum != default
            && !string.IsNullOrWhiteSpace(Klassrum);
    }

    // Returnerar true endast om Kurs och Klassrum är satta
    public bool TaBort()
    {
        return !string.IsNullOrWhiteSpace(Kurs)
            && !string.IsNullOrWhiteSpace(Klassrum);
    }
}
