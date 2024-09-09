int score = 0;

Console.WriteLine("10 question quiz, random answers (Write the option)");
Console.WriteLine("");

Console.WriteLine("1. How many AU is the distance to the sun?");
Console.WriteLine("A. 1     B. 0.3     C. 3"); string question1 = Console.ReadLine();
if (question1.ToLower() == "a") {score++;}else {score = score;}
Console.WriteLine("");

Console.WriteLine("2. How many kilometers long is Sweden?");
Console.WriteLine("A. 163     B. 1572     C. 6471"); string question2 = Console.ReadLine();
if (question2.ToLower() == "b") {score++;}else {score = score;}
Console.WriteLine("");

Console.WriteLine("3. How many bolts does the 'Öland bro' have?");
Console.WriteLine("A. 20000     B. 7428954     C. 86"); string question3 = Console.ReadLine();
if (question3.ToLower() == "b") {score++;}else {score = score;}
Console.WriteLine("");

Console.WriteLine("4. What is the official language of Sweden?");
Console.WriteLine("A. Pakistanian     B. Pigon     C. Swedish"); string question4 = Console.ReadLine();
if (question4.ToLower() == "c") {score++;}else {score = score;}
Console.WriteLine("");

Console.WriteLine("5. What is glass?");
Console.WriteLine("A. A solid     B. A liquid     C. A gas"); string question5 = Console.ReadLine();
if (question5.ToLower() == "b") {score++;}else {score = score;}
Console.WriteLine("");

Console.WriteLine("6. What is the best game ever?");
Console.WriteLine("A. Stormworks     B. Minecraft     C. Call of War"); string question6 = Console.ReadLine();
if (question6.ToLower() == "b") {score++;}else {score = score;}
Console.WriteLine("");

Console.WriteLine("7. What is the most spoken language?");
Console.WriteLine("A. Mandarin     B. Spanish     C. English"); string question7 = Console.ReadLine();
if (question7.ToLower() == "a") {score++;}else {score = score;}
Console.WriteLine("");

Console.WriteLine("8. Which of these languages are not related to Swedish?");
Console.WriteLine("A. Finnish     B. English     C. German"); string question8 = Console.ReadLine();
if (question8.ToLower() == "a") {score++;}else {score = score;}
Console.WriteLine("");

Console.WriteLine("9. Why are there so many questions?");
Console.WriteLine("A. why not     B. bc i can, and you suck     C. you suck"); string question9 = Console.ReadLine();
if (question9.ToLower() == "b") {score++;}else {score = score;}
Console.WriteLine("");

Console.WriteLine("10. What day was this written?");
Console.WriteLine("A. Monday     B. Some day     C. Friday"); string question10 = Console.ReadLine();
if (question10.ToLower() == "c") {score++;}else {score = score;}
Console.WriteLine("");

Console.WriteLine($"You got {score} points! That is {(score/10f)*100}% correct!");
Console.ReadLine();