using System.Globalization;

Console.WriteLine("Make your decision!");
Console.WriteLine("You either go to the left or right door, it's up to you! (left/right)");

string start = Console.ReadLine();
if (start.ToLower() == "left")
{
    Console.WriteLine("");
    Console.WriteLine("You went to China");
    Console.WriteLine("What do you do? Study or go for a walk? (study/walk)");
    string china1 = Console.ReadLine();
    if (china1.ToLower() == "study")
    {
        Console.WriteLine("");
        Console.WriteLine("You studied, what did you become? Engineer or dancer? (engineer/dancer)");
        string china2 = Console.ReadLine();
        if (china2.ToLower() == "engineer")
        {
            Console.WriteLine("");
            Console.WriteLine("Your parents approved of it, +100 social credit!");
            Console.ReadLine();
        }
        else if (china2.ToLower() == "dancer")
        {
            Console.WriteLine("");
            Console.WriteLine("Your parents didn't approve of it, -100 social credit!");
            Console.ReadLine();
        }
    }
    else if (china1.ToLower() == "walk")
    {
        Console.WriteLine("");
        Console.WriteLine("You went for a walk and met a friend, do you take them home? (yes/no)");
        string china3 = Console.ReadLine();
        if (china3.ToLower() == "yes")
        {
            Console.WriteLine("");
            Console.WriteLine("Your parents approved of him, +100 social credit!");
            Console.ReadLine();
        }
        else if (china3.ToLower() == "no")
        {
            Console.WriteLine("");
            Console.WriteLine("You missed a friend, emotional damage!");
            Console.ReadLine();
        }
    }
}
else if (start.ToLower() == "right")
{
    Console.WriteLine("");
    Console.WriteLine("You went to Sweden");
    Console.WriteLine("What do you do? Play games or go for a walk? (games/walk)");
    string sweden1 = Console.ReadLine();
    if (sweden1.ToLower() == "games")
    {
        Console.WriteLine("");
        Console.WriteLine("You played games, what did you do? Earned money or not? (yes/no)");
        string sweden2 = Console.ReadLine();
        if (sweden2.ToLower() == "yes")
        {
            Console.WriteLine("");
            Console.WriteLine("Your parents could retire from what you earnt");
            Console.ReadLine();
        }
        else if (sweden2.ToLower() == "no")
        {
            Console.WriteLine("");
            Console.WriteLine("Your parents told you to do better next time");
            Console.ReadLine();
        }
    }
    else if (sweden1.ToLower() == "walk")
    {
        Console.WriteLine("");
        Console.WriteLine("You went for a walk and met a friend, do you take them home? (yes/no)");
        string sweden3 = Console.ReadLine();
        if (sweden3.ToLower() == "yes")
        {
            Console.WriteLine("");
            Console.WriteLine("You became best friends and hung out every day");
            Console.ReadLine();
        }
        else if (sweden3.ToLower() == "no")
        {
            Console.WriteLine("");
            Console.WriteLine("You missed a friend, you became sad");
            Console.ReadLine();
        }
    }
}
else if (start.ToLower() == "ö")
{
    Console.WriteLine("");
    Console.WriteLine("Secret ending!");
    Console.ReadLine();
}
