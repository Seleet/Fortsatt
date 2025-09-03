using System;
using Users;




User[] users = new User[5];
int count = 0;
bool fortsatt = true;

do
{
    Console.Write("Mata in ditt namn: ");
    string namn = Console.ReadLine();

    Console.Write("Mata in din adress: ");
    string adress = Console.ReadLine();

    Console.Write("Mata in ditt postnr: ");
    int postnummer = int.Parse(Console.ReadLine());

    Console.Write("Mata in din postort: ");
    string postort = Console.ReadLine();

    users[count] = new User(namn, adress, postnummer, postort);
    count++;

    if (count < 5)
    {
        Console.Write("Vill du mata in fler? (Y/N): ");
        char svaret = Console.ReadKey().KeyChar;
        Console.WriteLine();
        if (char.ToUpper(svaret) == 'N')
            fortsatt = false;
    }
}
while (fortsatt && count < 5);

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"{users[i].Namn}, {users[i].Adress}, {users[i].Postnummer}, {users[i].Postort} ");
    Console.WriteLine();
}

