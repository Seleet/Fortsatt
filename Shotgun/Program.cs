int playerBullets = 0;
int cpuBullets = 0;
bool gameOver = false;
Random rnd = new Random();

while (!gameOver)
{
    int cpuMove = (cpuBullets > 0) ? rnd.Next(1, 4) : rnd.Next(2, 4);
    bool cpuChoiceShoot = cpuMove == 1;
    bool cpuChoiceReload = cpuMove == 2;
    bool cpuChoiceBlock = cpuMove == 3;

    if (cpuBullets == 3 && playerBullets < 3)
    {
        Console.WriteLine("You get shotgunned and lose!");
        gameOver = true;
    }
    else if (playerBullets == 3 && cpuBullets == 3)
    {
        Console.WriteLine("Double knockout!");
        gameOver = true;
    }
    else
    {
        if (playerBullets == 3)
        {
            Console.WriteLine("Howdy Stranger!, Welcome to shotgun!");
            Console.WriteLine($"You got {playerBullets} bullets.");
            Console.WriteLine($"CPU got {cpuBullets}");
            Console.WriteLine("Make your Move!");
            Console.WriteLine("1. Shoot ");
            Console.WriteLine("2. Reload ");
            Console.WriteLine("3. Block ");
            Console.WriteLine("4. Shotgun and WIN!");
        }
        else
        {
            Console.WriteLine("Howdy Stranger!, Welcome to shotgun!");
            Console.WriteLine($"You got {playerBullets} bullets.");
            Console.WriteLine($"CPU got {cpuBullets}");
            Console.WriteLine("Make your Move!");
            Console.WriteLine("1. Shoot ");
            Console.WriteLine("2. Reload ");
            Console.WriteLine("3. Block ");
        }

        string input = Console.ReadLine();

        if (input == "1")
        {
            if (playerBullets >= 1)
            {
                Console.WriteLine("You fire your gun and...");
                Shoot(cpuChoiceShoot, cpuChoiceReload, cpuChoiceBlock, ref playerBullets, ref cpuBullets, ref gameOver);
            }
            else
            {
                Console.WriteLine("Click! No bullets.");
            }
        }
        else if (input == "2")
        {
            Console.WriteLine("You reload your gun and...");
            Reload(cpuChoiceShoot, cpuChoiceReload, cpuChoiceBlock, ref playerBullets, ref cpuBullets, ref gameOver);
        }
        else if (input == "3")
        {
            Console.WriteLine("You block and...");
            Block(cpuChoiceShoot, cpuChoiceReload, cpuChoiceBlock, ref playerBullets, ref cpuBullets);
        }
        else if (input == "4" && playerBullets == 3)
        {
            Console.WriteLine("You SHOTGUN and WIN!");
            gameOver = true;
        }
        else
        {
            Console.WriteLine("Invalid choice, make your move.. punk...");
        }
    }
}

void Shoot(bool cpuChoiceShoot, bool cpuChoiceReload, bool cpuChoiceBlock, ref int playerBullets, ref int cpuBullets, ref bool gameOver)
{
    if (cpuChoiceShoot)
    {
        Console.WriteLine("You both shoot, bullets take each other out and nothing happens!");
        playerBullets -= 1;
        cpuBullets -= 1;
    }
    else if (cpuChoiceReload)
    {
        Console.WriteLine("You shoot while CPU was reloading, you win!");
        playerBullets -= 1;
        gameOver = true;
    }
    else if (cpuChoiceBlock)
    {
        Console.WriteLine("You shoot while CPU is blocking! You lose a bullet.");
        playerBullets -= 1;
    }
}

void Reload(bool cpuChoiceShoot, bool cpuChoiceReload, bool cpuChoiceBlock, ref int playerBullets, ref int cpuBullets, ref bool gameOver)
{
    if (cpuChoiceShoot)
    {
        Console.WriteLine("You LOSE!");
        cpuBullets -= 1;
        gameOver = true;
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

void Block(bool cpuChoiceShoot, bool cpuChoiceReload, bool cpuChoiceBlock, ref int playerBullets, ref int cpuBullets)
{
    if (cpuChoiceShoot)
    {
        Console.WriteLine("You Block, CPU Shoots and loses one bullet!");
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
