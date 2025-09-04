using System.Text;
Console.Write("Mata in en sträng: ");
string string1 = Console.ReadLine() ?? "";
Console.Write("Mata in en sträng till: ");
string string2 = Console.ReadLine() ?? "";
Console.Write("Mata in en sträng till: ");
string string3 = Console.ReadLine() ?? "";
string result = string1 + string2 + string3;
Console.WriteLine(result);
string result2 = string.Concat(string1, string2, string3);
Console.WriteLine(result2);

string result3 = string.Join(" ", string1, string2, string3);
Console.WriteLine(result3);
string result4 = $"{string1} {string2} {string3}";
Console.WriteLine(result);


var sb = new StringBuilder();
sb.Append(string1);
sb.Append(string2);
sb.Append(string3);

Console.WriteLine(sb.ToString());

