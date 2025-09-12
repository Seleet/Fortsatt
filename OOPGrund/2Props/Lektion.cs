public class Lektion
{
    public string Kurs { get; set; } = "";
    public string Klassrum { get; set; } = "";
    public DateTime Start { get; set; }
    public DateTime Slut  { get; set; }

    // Bokningsregeln: måste finnas Kurs+Klassrum och Slut > Start
    public bool Boka() =>
        !string.IsNullOrWhiteSpace(Kurs)
        && !string.IsNullOrWhiteSpace(Klassrum)
        && Slut > Start;

    // TaBort enligt din uppgift: bara kolla att dessa är satta
    public bool TaBort() =>
        !string.IsNullOrWhiteSpace(Kurs)
        && !string.IsNullOrWhiteSpace(Klassrum);

    // Hjälp: skapa en lektion på en viss dag med start/sluttid (HH:mm)
    public static Lektion SkapaDag(
        string kurs, string klassrum, DateOnly datum,
        string startTid = "09:00", string slutTid = "10:00")
    {
        var (sh, sm) = ParseHM(startTid);
        var (eh, em) = ParseHM(slutTid);
        return new Lektion
        {
            Kurs = kurs,
            Klassrum = klassrum,
            Start = datum.ToDateTime(new TimeOnly(sh, sm)),
            Slut  = datum.ToDateTime(new TimeOnly(eh, em))
        };
    }

    private static (int h, int m) ParseHM(string s)
    {
        var parts = s.Split(':');
        return (int.Parse(parts[0]), int.Parse(parts[1]));
    }
}
