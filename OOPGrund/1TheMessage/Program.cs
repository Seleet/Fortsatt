using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Skriv in en text: ");
        string input = Console.ReadLine();

      
        Meddelande meddelande = new Meddelande();
        meddelande.Text = input;

  
        string resultat = meddelande.VisaMeddelande();
        Console.WriteLine(resultat);

   
        string filePath = "meddelande.txt";
        File.WriteAllText(filePath, resultat);
        Console.WriteLine($"\nMeddelandet sparades i filen '{filePath}'.");
    }
}
