Console.WriteLine("Vilket år föddes du (4 siffror)");
var year = Console.ReadLine();
var age = DateTime.Now.Year - int.Parse(year);
Console.WriteLine($"Du är {age} år gammal");