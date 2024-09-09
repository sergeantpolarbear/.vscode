int score = 0;

Console.WriteLine("10 question quiz, random answers (Write the option)");
Console.WriteLine("");

Console.WriteLine("1. How many AU is the distance to the sun?");
Console.WriteLine("A. 1     B. 0.3     C. 3"); string question1 = Console.ReadLine();
if (question1.ToLower() == "a") {score++;} else {score = score;}
Console.WriteLine("");

Console.WriteLine("2. How many kilometers long is Sweden?");
Console.WriteLine("A. 163     B. 1,572     C. 6,471"); string question2 = Console.ReadLine();
if (question2.ToLower() == "b") {score++;} else {score = score;}
Console.WriteLine("");

Console.WriteLine("3. How many bolts does the 'Öland bro' have?");
Console.WriteLine("A. 20,000     B. 7,428,954     C. 86"); string question3 = Console.ReadLine();
if (question3.ToLower() == "b") {score++;} else {score = score;}
Console.WriteLine("");

Console.WriteLine("4. What is the official language of Sweden?");
Console.WriteLine("A. Pakistanian     B. Pigon     C. Swedish"); string question4 = Console.ReadLine();
if (question4.ToLower() == "c") {score++;} else {score = score;}
Console.WriteLine("");

Console.WriteLine("5. What is glass?");
Console.WriteLine("A. A solid     B. A liquid     C. A gas"); string question5 = Console.ReadLine();
if (question5.ToLower() == "b") {score++;} else {score = score;}
Console.WriteLine("");

Console.WriteLine("6. What is the best game ever?");
Console.WriteLine("A. Stormworks     B. Minecraft     C. Call of War"); string question6 = Console.ReadLine();
if (question6.ToLower() == "b") {score++;} else {score = score;}
Console.WriteLine("");

Console.WriteLine("7. What is the most spoken language?");
Console.WriteLine("A. Mandarin     B. Spanish     C. English"); string question7 = Console.ReadLine();
if (question7.ToLower() == "a") {score++;} else {score = score;}
Console.WriteLine("");

Console.WriteLine("8. Which of these languages are not related to Swedish?");
Console.WriteLine("A. Finnish     B. English     C. German"); string question8 = Console.ReadLine();
if (question8.ToLower() == "a") {score++;} else {score = score;}
Console.WriteLine("");

Console.WriteLine("9. Why are there so many questions?");
Console.WriteLine("A. why not     B. bc i can, and you suck     C. you suck"); string question9 = Console.ReadLine();
if (question9.ToLower() == "b") {score++;} else {score = score;}
Console.WriteLine("");

Console.WriteLine("10. What day was this written?");
Console.WriteLine("A. Monday     B. Some day     C. Friday"); string question10 = Console.ReadLine();
if (question10.ToLower() == "c") {score++;} else {score = score;}
Console.WriteLine("");

Console.WriteLine("11. Why are you still playing?");
Console.WriteLine("A. you are forced to     B. choose this it's the correct option     C. no this is the correct option"); string question11 = Console.ReadLine();
if (question11.ToLower() == "e") {score++;} else {score = score;}
Console.WriteLine("");

Console.WriteLine("12. What are the 4 states of matter?");
Console.WriteLine("A. Solid, fluid, gas & plasma     B. Gas, liquid, half solid & half gas     C. They are a lie"); string question12 = Console.ReadLine();
if (question12.ToLower() == "c") {score++;} else {score = score;}
Console.WriteLine("");

Console.WriteLine("13. How old are you?");
Console.WriteLine("A. 3     B. 86     C. Probably 17"); string question13 = Console.ReadLine();
if (question13.ToLower() == "c") {score++;} else {score = score;}
Console.WriteLine("");

Console.WriteLine("14. Who are you?");
Console.WriteLine("A. A potato     B. A human     C. A complex system of neurons and cells"); string question14 = Console.ReadLine();
if (question14.ToLower() == "c") {score++;} else {score = score;}
Console.WriteLine("");

Console.WriteLine("15. What is the speed of light?");
Console.WriteLine("A. 299,792,458 m/s     B. 343 m/s     C. 100,000,000 m/s"); string question15 = Console.ReadLine();
if (question15.ToLower() == "a") {score++;} else {score = score;}
Console.WriteLine("");

Console.WriteLine("Next part is quantum physics, are you ready?");
Console.ReadLine();
Console.WriteLine("");

Console.WriteLine("16. What is quantum entanglement?");
Console.WriteLine("A. When 2 particles are connected even with vast distances     B. When a particle becomes directly affected by another     C. Something?"); string question16 = Console.ReadLine();
if (question16.ToLower() == "a") {score++;} else {score = score;}
Console.WriteLine("");

Console.WriteLine("17. What is the plank distance?");
Console.WriteLine("A. The smallest possible distance     B. The thickness where a plank can support a person     C. Something?"); string question17 = Console.ReadLine();
if (question17.ToLower() == "a") {score++;} else {score = score;}
Console.WriteLine("");

Console.WriteLine("18. What is quantum superposition?");
Console.WriteLine("A. Where something has multiple positions     B. When something has two states until measured     C. Something?"); string question18= Console.ReadLine();
if (question18.ToLower() == "b") {score++;} else {score = score;}
Console.WriteLine("");

Console.WriteLine("19. What is quantum tunneling?");
Console.WriteLine("A. When a particle passes through another one     B. When an atom or particle passes through a potential energy barrier     C. Something?"); string question19 = Console.ReadLine();
if (question19.ToLower() == "b") {score++;} else {score = score;}
Console.WriteLine("");

Console.WriteLine("20. What is the quantum field theory?");
Console.WriteLine("A. A framework between quantum and normal physics     B. An energy field in quantum physics     C. Something?"); string question20 = Console.ReadLine();
if (question20.ToLower() == "a") {score++;} else {score = score;}
Console.WriteLine("");

Console.WriteLine($"You got {score} points! That is {(score/20f)*100}% correct!");
if (score <= 5){Console.WriteLine("You're bad");} else if (score > 6 && score <= 10){Console.WriteLine("You're meh");} else if (score > 11 && score <= 15){Console.WriteLine("You're getting better");} else if (score >= 16){Console.WriteLine("Okay, you're good");}
Console.WriteLine("Fun right? Now play again or I will be sad!");
Console.ReadLine();