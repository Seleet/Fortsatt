using InkopsListaApp;  

class Program
{
    static void Main()
    {
        Console.Write("Hur många varor vill du ha på listan? ");
        int antal = int.Parse(Console.ReadLine());

        Vara[] inkopslista = new Vara[antal];

        for (int i = 0; i < antal; i++)
        {
            Console.Write("Namn på varan?: ");
            string namn = (Console.ReadLine());
            Console.Write("Pris på varan?: ");
            decimal pris = decimal.Parse(Console.ReadLine());
            Console.Write("Produktnummer på varan?: ");
            int produktnummer = int.Parse(Console.ReadLine());

            inkopslista[i] = new Vara(namn, pris, produktnummer);

        }
        foreach (Vara vara in inkopslista)
        {
           Console.WriteLine($"{vara.Namn}, {vara.Pris} kr, produktnummer {vara.Produktnummer}");

        }

    }
}
