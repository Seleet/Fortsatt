using System;

class Program
{
    static void Main()
    {
        Console.Write("Skriv in en text: ");
        string text = Console.ReadLine();

        Translate(ref text);   
        Console.WriteLine(text);
    }

    static void Translate(ref string text)
    {
        string result = "";

        char[] vokaler = { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };

        foreach (char ch in text)
        {
            char c = char.ToLower(ch);

            
            if (char.IsLetter(c) && Array.IndexOf(vokaler, c) == -1)
            {
                result += ch + "o" + char.ToLower(ch);
            }
            else
            {
                result += ch;
            }
        }

        text = result; 
    }
}
