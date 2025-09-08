// See https://aka.ms/new-console-template for more information
using System.Formats.Asn1;
using System.Linq.Expressions;

Console.WriteLine("Howdy Stranger!, Welcome to shotgun!");
Console.WriteLine("Make your Move!");
Console.WriteLine("1. Shoot ");
Console.WriteLine("2. Reload ");
Console.WriteLine("3. Block ");
string input = Console.ReadLine();

if (input == "1")
{
    Console.WriteLine("You fire your gun and...");

}
else if (input == "2")
{
    Console.WriteLine("Your reload your gun and...");
}
else if (input == "3")
{
    Console.WriteLine("You block and...");
}
else
{
    Console.WriteLine("Invalid choice, make your move.. punk...");
}

int playerBullets = 0;
int cpuBullets = 0;


static int shoot()
    if (cpuChoiceShoot)
    {
        System.Console.WriteLine("You both shoot, bullets takes each other out and nothing happens!");
    }

    else if (cpuChoiceReload)
    {
     System.Console.WriteLine("You shoot while CPU was reloading, you win!");
    }

    else if (cpuChoiceBlock)
    {
        Console.WriteLine("You shoot while CPU is blocking! You loose a bullet.");
          playerBullets -= 1;

    }

static void Reload(bool cpuChoiceShoot, bool cpuChoiceReload, bool cpuChoiceBlock, ref int playerBullets, ref int cpuBullets)
{
    if (cpuChoiceShoot)
    {
        Console.WriteLine("You LOSE!");
    }
    else if (cpuChoiceReload)
    {
        playerBullets += 1;
        cpuBullets += 1;
    }
    else if (cpuChoiceBlock)
    {
        playerBullets += 1;
    }
}


static void Block(bool cpuChoiceShoot, bool cpuChoiceReload, bool cpuChoiceBlock, ref int playerBullets, ref int cpuBullets)
{
    if (cpuChoiceShoot)
    {
        Console.WriteLine("You Block, CPU Shoots and looses one bullet!");
        cpuBullets -= 1;
    }
    else if (cpuChoiceReload)
    {
        Console.WriteLine("You Block, CPU Reloads and loads up another bullet!");
        cpuBullets += 1;
    }
    else if (cpuChoiceBlock)
    {
        Console.WriteLine("You Block, CPU blocks, nothing happens!");
    }
}
