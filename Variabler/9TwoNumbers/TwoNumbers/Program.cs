Console.WriteLine("Mata in ett tal:");
int input = int.Parse(Console.ReadLine());

Console.WriteLine("Mata in ett annat tal:");
int input2 = int.Parse(Console.ReadLine());

int sum = input + input2;
int average = sum / 2;
int difference = Math.Abs(input - input2);

Console.WriteLine($"Medelvärdet: {average}\nSumman: {sum}\nDifferensen: {difference}");
