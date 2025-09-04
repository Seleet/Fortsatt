class Program
{
    public static void Main()
    {
        int vissSumma = 1337;
        System.Console.WriteLine($"Momsen på {vissSumma} är {Momsen(vissSumma)}");
    }
    public static decimal Momsen(int Summan)
    {

        decimal momsen = Summan * 0.25m;
        return momsen;
    }
}