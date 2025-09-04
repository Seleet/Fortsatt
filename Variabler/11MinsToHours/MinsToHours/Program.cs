// See https://aka.ms/new-console-template for more information
Console.WriteLine("Mata in antal minuter(minst 60minuter):");
int minuter = Convert.ToInt32(Console.ReadLine());
int timmar = minuter / 60;
int minuterKvar = minuter % 60;
Console.WriteLine($"Detta är {timmar} timmar och {minuterKvar} minuter");
