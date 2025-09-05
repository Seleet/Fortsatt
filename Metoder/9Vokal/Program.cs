
class Program

{

    static void Main()
    {

        Console.WriteLine("Skriv in en bokstav: ");
        char bokstav = Console.ReadKey().KeyChar;
        Console.WriteLine();

        if (IsVowel(bokstav))
        {
            Console.WriteLine($"{bokstav} är en vokal");
        }
        else
        {
            Console.WriteLine($"{bokstav} är en konsonant");

        }

    }



    static bool IsVowel(char bokstav)
    {
        char[] vokaler = { 'a', 'e', 'i', 'o', 'u', 'y', 'å', 'ä', 'ö' };
        char c = char.ToLower(bokstav);

        for (int i = 0; i < vokaler.Length; i++)
            if (c == vokaler[i])
                return true;

        return false;
    }

}


