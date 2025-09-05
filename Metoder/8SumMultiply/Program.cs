

int[] heltal = new int[] { 1, 2, 3, 4};


Console.WriteLine($"Adderat blir det {Sum(heltal)}, och multiplicerat blir det {Multiply(heltal)}");
Sum(heltal);
Multiply(heltal);

static int Sum(int[] Heltal)
{
    int summerat = 0;
    for (int i = 0; i < Heltal.Length; i++)
    {
        summerat += Heltal[i];
    }
     return summerat;

}

static int Multiply(int [] Heltal)
{
    int multiplicerat = 1;
    for (int i = 0; i < Heltal.Length; i++)
    {
        multiplicerat *= Heltal[i];


    }
    return multiplicerat;
}
