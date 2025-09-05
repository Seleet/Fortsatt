using System;

class Program
{
    static void Main()
    {
        

        string[] enListaStrings = { "conny", "albatross", "sax", "kamel", "ost" };

        Console.WriteLine("Längsta ordet är: " + HittaLangstaOrdet(enListaStrings));
    }

    static string HittaLangstaOrdet(string[] Meningar)
    {
        string langtOrd = Meningar[0];

        for (int i = 1; i < Meningar.Length; i++)
        {
            if (Meningar[i].Length > langtOrd.Length)
            {
                langtOrd = Meningar[i];
            }
        }

        return langtOrd;
    }
}
