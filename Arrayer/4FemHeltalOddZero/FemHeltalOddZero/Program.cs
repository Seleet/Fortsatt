int[] oddToZero = new int[] { 1, 4, 15, 6, 75 };
for (int i = 0; i < oddToZero.Length; i++)
{
    if (oddToZero[i] % 2 != 0)
        oddToZero[i] = 0;
}
foreach (int i in oddToZero)
{
    Console.Write($"{i} ");
}