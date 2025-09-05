


static void ReferenceOut(ref int parraRef, out int parraUt)
{
    parraRef += 100;
    parraUt = 1337;
}
int value1 = 15;
int value2;

ReferenceOut(ref value1, out value2);

Console.WriteLine($"value1 efter: {value1}");
Console.WriteLine($"value2 efter: {value2}");
