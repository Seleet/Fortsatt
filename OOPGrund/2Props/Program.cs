Console.WriteLine("Vilket är kursnamnet?");
string kursnamn = Console.ReadLine();

Console.WriteLine("Vilket är startdatumet? (ÅÅÅÅ-MM-DD)");
DateOnly startdatum = DateOnly.Parse(Console.ReadLine());

Console.WriteLine("Vilket är slutdatumet? (ÅÅÅÅ-MM-DD)");
DateOnly slutdatum = DateOnly.Parse(Console.ReadLine());

Console.WriteLine("Hur många poäng för kursen?");
int poäng = int.Parse(Console.ReadLine());

// Skapa kursen
Kurs kurs1 = new Kurs(kursnamn, startdatum, slutdatum, poäng);

// Skriv ut all info
Console.WriteLine($"\nKursnamn = {kurs1.KursNamn}");
Console.WriteLine($"Startdatum = {kurs1.StartDatum}");
Console.WriteLine($"Slutdatum = {kurs1.SlutDatum}");
Console.WriteLine($"Poäng = {kurs1.Poäng}");
Console.WriteLine($"Antal kursdagar = {kurs1.AntalKursdagar}");
Console.WriteLine($"Poäng per kursdag = {kurs1.PoangPerKursdag()}");

Console.WriteLine($"");
string förnamn = "kenny";
string efternamn = "jönsson";
string email = "k.jönsson@mail.nu";
string telefon = "070-335548";


Student nyStudent = new Student(förnamn, efternamn, email, telefon);
Console.WriteLine($"{nyStudent.Förnamn} {nyStudent.Efternamn} {nyStudent.Email} {nyStudent.Telefon}");

foreach (var b in Student.HamtaBetyg())
{
    Console.WriteLine(b);

        Larare larare = new Larare
        {
            Förnamn = "Anna",
            Efternamn = "Karlsson",
            Email = "anna.karlsson@skola.se",
            Telefon = "070-1234567"
        };

        Console.WriteLine($"{larare.Förnamn} {larare.Efternamn} är ansvarig för:");
        
        List<Kurs> kurser = larare.AnsvarigForKurser();
        foreach (var kurs in kurser)
        {
            Console.WriteLine($"- {kurs.KursNamn} ({kurs.Poäng} poäng)");
        }

        }

