class Program
{

    static void Main()
    {

        Console.WriteLine("Mata in din ålder: ");
        int age = int.Parse(Console.Readline());

    }
    static bool Myndig(int age)
    {
        bool myndig;

        if (age >= 18)
        {
            return myndig = true;
        }
        else
        {
            return myndig = false;
        }


    }

}