int counter = 0;
for (int i = 1; i <= 1000; i++)
{
    if (i % 17 == 0)
    {
        counter++;
    }

}
Console.WriteLine($"Mellan 1-1000 finns det {counter} tal som är delbara med 17.");
