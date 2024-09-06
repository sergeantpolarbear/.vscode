using System.Globalization;

Console.WriteLine("Make your decision!");
Console.WriteLine("You either go to the left or right door, it's up to you! (left/right)");
// the cookies aren't here and also, tell me why you're snooping through my code
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
            Console.WriteLine("Your parents approved of it, +100 social credit! You got a star.");
            Console.ReadLine();
        }
        else if (china2.ToLower() == "dancer")
        {
            Console.WriteLine("");
            Console.WriteLine("Your parents didn't approve of it, -100 social credit! You also got disowned.");
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
            Console.WriteLine("Your parents approved of him, +100 social credit! You had a sleepover.");
            Console.ReadLine();
        }
        else if (china3.ToLower() == "no")
        {
            Console.WriteLine("");
            Console.WriteLine("You missed a friend, emotional damage! You had to stand on your knees on rice for 8 hours.");
            Console.ReadLine();
        }
    }
}
// here have a cookie while snooping through my code
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
            Console.WriteLine("Your parents could retire from what you earnt. They got happy.");
            Console.ReadLine();
        }
        else if (sweden2.ToLower() == "no")
        {
            Console.WriteLine("");
            Console.WriteLine("Your parents told you to do better next time. They gave you a star for trying.");
            Console.ReadLine();
        }
    }
    // how did the cookie taste?
    else if (sweden1.ToLower() == "walk")
    {
        Console.WriteLine("");
        Console.WriteLine("You went for a walk and met a friend, do you take them home? (yes/no)");
        string sweden3 = Console.ReadLine();
        if (sweden3.ToLower() == "yes")
        {
            Console.WriteLine("");
            Console.WriteLine("You became best friends and hung out every day. You got ice cream.");
            Console.ReadLine();
        }
        else if (sweden3.ToLower() == "no")
        {
            Console.WriteLine("");
            Console.WriteLine("You missed a friend, you became sad. You became depressed.");
            Console.ReadLine();
        }
    }
}
else if (start.ToLower() == "ö")
{
    Console.WriteLine("");
    Console.WriteLine("Secret ending! Also how tf do you know about this? Stop snooping in my damn code!");
    Console.ReadLine();
}
// no gerald, you're not getting another cookie!