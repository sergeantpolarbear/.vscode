Console.WriteLine("Användarnamn: ");
string name = Console.ReadLine();

if (name.ToLower() == "Filip" || name.ToLower() == "filip")
{
    Console.WriteLine("Logged in! Welcome!");
    Console.WriteLine("YIPPIE!!!");
}
else if (name.ToLower() == "Theodor" || name.ToLower() == "theodor")
{
    Console.WriteLine("Okay fine, but only this time");
    Console.WriteLine("I ain't wanna see you here more");
}
else
{
    Console.WriteLine("NUH UH!");
    Console.WriteLine("OH HELL NAH");
}

Console.ReadLine();