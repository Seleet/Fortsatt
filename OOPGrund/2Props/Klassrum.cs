public class Klassrum
{
    public int AntalStolar { get; set; }
    public double Yta { get; set; }

    private readonly List<Lektion> _lektioner = new();

    public bool KontrolleraStorlek(double minYta) => Yta >= minYta;

    public List<Lektion> HamtaLektioner() => new List<Lektion>(_lektioner);

    public bool KontrolleraLedigt(DateTime start, DateTime slut)
    {
        if (slut <= start) return false;
        foreach (var l in _lektioner)
            if (IntervallKrockar(l.Start, l.Slut, start, slut))
                return false;
        return true;
    }

    public bool Boka(Lektion lektion)
    {
        if (!lektion.Boka()) return false;
        if (!KontrolleraLedigt(lektion.Start, lektion.Slut)) return false;
        _lektioner.Add(lektion);
        return true;
    }

    private static bool IntervallKrockar(DateTime aStart, DateTime aSlut, DateTime bStart, DateTime bSlut)
        => aStart < bSlut && bStart < aSlut;
}
