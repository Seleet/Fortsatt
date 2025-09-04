using System;

class Program
{
    public static void Main()
    {
        string katt = "katt";
        string mannen = "mannen";
        System.Console.WriteLine($"{StringCombiner(katt, mannen)}");

    }
    public static string StringCombiner(string Ord1, string Ord2)
    {
        string ord1 = Ord1;
        string ord2 = Ord2;
        string dubbelstring = ord1 + ord2;
        return dubbelstring;

    }
}
