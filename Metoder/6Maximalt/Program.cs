using System;

class Program
{
    static void Main()
    {
        int resultat = KontrolleraMaxVarde(5, 0, 8);
        Console.WriteLine($"Största värdet: {resultat}");
    }

    static int MaxVarde2(int a, int b)
    {
        if (a > b)
            return a;
        else
            return b;
    }

    static int MaxVarde3(int a, int b, int c)
    {
        int störst = a;

        if (b > störst)
            störst = b;
        if (c > störst)
            störst = c;

        return störst;
    }

    static int KontrolleraMaxVarde(int x, int y, int z)
    {
        if (x == 0)
            return MaxVarde2(y, z);
        else if (y == 0)
            return MaxVarde2(x, z);
        else if (z == 0)
            return MaxVarde2(x, y);
        else
            return MaxVarde3(x, y, z);
    }
}
