Console.WriteLine("Summera och ta medelvärdet av alla jämna tal mellan 265 och 290.");

int sum = 0;
int count = 0;

for (int i = 265; i <= 290; i++)
{
    if (i % 2 == 0) // jämnt tal
    {
        sum += i;
        count++;
    }
}

double average = (double)sum / count;

Console.WriteLine($"Summan av de jämna talen är: {sum}");
Console.WriteLine($"Medelvärdet av de jämna talen är: {average}");
