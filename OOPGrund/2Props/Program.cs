using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // --- Kurs (inmatning) ---
        Console.WriteLine("Vilket är kursnamnet?");
        string kursnamn = Console.ReadLine() ?? "";

        Console.WriteLine("Vilket är startdatumet? (ÅÅÅÅ-MM-DD)");
        DateOnly startdatum = DateOnly.Parse(Console.ReadLine()!);

        Console.WriteLine("Vilket är slutdatumet? (ÅÅÅÅ-MM-DD)");
        DateOnly slutdatum = DateOnly.Parse(Console.ReadLine()!);

        Console.WriteLine("Hur många poäng för kursen?");
        int poäng = int.Parse(Console.ReadLine()!);

        var kurs1 = new Kurs(kursnamn, startdatum, slutdatum, poäng);

        Console.WriteLine($"\nKursnamn = {kurs1.KursNamn}");
        Console.WriteLine($"Startdatum = {kurs1.StartDatum}");
        Console.WriteLine($"Slutdatum = {kurs1.SlutDatum}");
        Console.WriteLine($"Poäng = {kurs1.Poäng}");
        Console.WriteLine($"Antal kursdagar = {kurs1.AntalKursdagar}");
        Console.WriteLine($"Poäng per kursdag = {kurs1.PoangPerKursdag():F6}");

        // --- Student (inmatning + sammanfattning) ---
        Console.Write("Förnamn: ");
        string förnamn = Console.ReadLine() ?? "";

        Console.Write("Efternamn: ");
        string efternamn = Console.ReadLine() ?? "";

        Console.Write("Email: ");
        string email = Console.ReadLine() ?? "";

        Console.Write("Telefon: ");
        string telefon = Console.ReadLine() ?? "";

        var student = new Student(förnamn, efternamn, email, telefon);
        Console.WriteLine(student.Sammanfattning());

        // --- Betyg ---
        foreach (var b in Student.HamtaBetyg())
            Console.WriteLine(b);

        // --- Lärare + inkapslad kurslista ---
        var larare = new Larare
        {
            Förnamn = "Anna",
            Efternamn = "Karlsson",
            Email = "anna.karlsson@skola.se",
            Telefon = "070-1234567"
        };

        Console.WriteLine($"{larare.Förnamn} {larare.Efternamn} är ansvarig för:");
        List<Kurs> kurser = larare.AnsvarigForKurser();
        foreach (var k in kurser)
            Console.WriteLine($"- {k.KursNamn} ({k.Poäng} poäng)");

        // --- Lektion: Boka/TaBort (Start/Slut med DateTime) ---
        var lektion1 = new Lektion
        {
            Kurs = "C# Grund",
            Klassrum = "A101",
            Start = new DateTime(2025, 9, 15, 9, 0, 0),
            Slut = new DateTime(2025, 9, 15, 11, 0, 0)
        };
        Console.WriteLine($"Boka(): {lektion1.Boka()}");
        Console.WriteLine($"TaBort(): {lektion1.TaBort()}");

        var lektion2 = new Lektion
        {
            Kurs = "ASP.NET",
            Klassrum = "B202",
            Start = new DateTime(2025, 9, 16, 10, 0, 0),
            Slut = new DateTime(2025, 9, 16, 12, 0, 0)
        };
        Console.WriteLine($"Boka(): {lektion2.Boka()}");
        Console.WriteLine($"TaBort(): {lektion2.TaBort()}");

        var lektion3 = new Lektion
        {
            Kurs = "", // saknar kurs -> Boka()/TaBort() visar false där det ska
            Klassrum = "C303",
            Start = new DateTime(2025, 9, 20, 13, 0, 0),
            Slut = new DateTime(2025, 9, 20, 14, 0, 0)
        };
        Console.WriteLine($"Boka(): {lektion3.Boka()}");
        Console.WriteLine($"TaBort(): {lektion3.TaBort()}");

        // --- Klassrum: storlek + ledighetskontroll/bokningar ---
        var salA = new Klassrum { AntalStolar = 30, Yta = 48.5 };
        Console.WriteLine($"KontrolleraStorlek(40): {salA.KontrolleraStorlek(40)}"); // True

        var l1 = new Lektion
        {
            Kurs = "C# Grund",
            Klassrum = "A101",
            Start = new DateTime(2025, 9, 15, 9, 0, 0),
            Slut = new DateTime(2025, 9, 15, 11, 0, 0)
        };
        var l2 = new Lektion
        {
            Kurs = "ASP.NET",
            Klassrum = "A101",
            Start = new DateTime(2025, 9, 15, 10, 0, 0), // överlappar l1
            Slut = new DateTime(2025, 9, 15, 12, 0, 0)
        };

        Console.WriteLine($"Ledigt 9–11?  {salA.KontrolleraLedigt(l1.Start, l1.Slut)}"); // True
        Console.WriteLine($"Boka l1:      {salA.Boka(l1)}");                             // True
        Console.WriteLine($"Ledigt 10–12? {salA.KontrolleraLedigt(l2.Start, l2.Slut)}"); // False
        Console.WriteLine($"Boka l2:      {salA.Boka(l2)}");                             // False

        Console.WriteLine("\nBokade lektioner i sal A:");
        foreach (var lek in salA.HamtaLektioner())
            Console.WriteLine($"- {lek.Kurs} {lek.Start:g}–{lek.Slut:t} ({lek.Klassrum})");
    }
}
