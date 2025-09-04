class Program
{
    public static void Main()
    {
        int vissSumma = 1337;
        System.Console.WriteLine($"Momsen på {vissSumma} är {Momsen(vissSumma)}");
    }
    public static double Momsen(int Summan)
    {

        double momsen = Summan * 0.25;
        return momsen;
    }
}