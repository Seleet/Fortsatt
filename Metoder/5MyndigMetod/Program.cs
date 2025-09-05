using System;

class Program
{
    static void Main()
    {
        Console.Write("Mata in din ålder: ");
        int age = int.Parse(Console.ReadLine());

        if (Myndig(age))
        {
            Console.WriteLine("Du är myndig.");
        }
        else
        {
            Console.WriteLine("Du är inte myndig.");
        }
    }

    static bool Myndig(int age)
    {
        return age >= 18;
    }
}
