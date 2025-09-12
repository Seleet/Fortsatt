
public class Student
{

    public string Förnamn { get; set; }

    public string Efternamn { get; set; }

    public string Email { get; set; }
    public string Telefon { get; set; }

    public Student(string förnamn, string efternamn, string email, string telefon)
    {
        Förnamn = förnamn;
        Efternamn = efternamn;
        Email = email;
        Telefon = telefon;

    }

    public static string[] HamtaBetyg()
    {
        string[] betyg = { "Programmering C# - G", "ASP.NET med C# - VG", "Frontend utveckling - VG" };
        return betyg;
    }

    public void RensaData()
    {
        Förnamn = "";
        Efternamn = "";
        Email = "";
        Telefon = "";
    }

    public string Sammanfattning()
    {
        return $"Student: {Förnamn} {Efternamn}, Email: {Email}, Telefon: {Telefon}";

    }

}










