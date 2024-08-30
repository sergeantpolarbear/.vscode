string name;
string name1;
string name2;
string noun1;
string noun2;
string adjective1;
string adjective2;
string funny1;
string funny2;
string verb1;
string verb2;

Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.Clear();

Console.WriteLine("What is your name?");
name = Console.ReadLine();
Console.WriteLine("");

// Console.WriteLine("Hej " + name);
Console.WriteLine($"Hello name {name}, are you ready to play this extremely very horrific nightmare game?");
Console.WriteLine("");

Console.WriteLine("A name:");
name1 = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Yet another name:");
name2 = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine("A noun:");
noun1 = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Yet another noun:");
noun2 = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine("An adjective:");
adjective1 = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Yet another adjective:");
adjective2 = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine("A funny word:");
funny1 = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Yet another funny word:");
funny2 = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine("A verb:");
verb1 = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Yet another verb:");
verb2 = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine($"There once was a friend named {name1} who had another friend named {name2}. They were {verb1} while they were {verb2}.");
Console.WriteLine($"{name1} was {adjective1} and {name2} was {adjective2}.");
Console.WriteLine($"While they were {verb1}, they same some {noun1} and {noun2}.");
Console.WriteLine($"When they say it, {name1} {funny1} and {name2} {funny2}.");
Console.WriteLine("");

Console.WriteLine("hello you komputer have virus please contact microsoft support or press space");
Console.WriteLine("");

Console.ReadLine();