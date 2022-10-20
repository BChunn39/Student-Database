
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
bool goAgain;
do
{
    string[] studentName = new string[] { "Beth", "Jerry", "Rick", "Morty" };
    for (int i = 0; i < studentName.Length; i++)
    {
        int studentNumber = i + 1;
        Console.WriteLine($"{studentNumber} {studentName[i]}");
    }
    string[] studentHometown = new string[] { "Farmington", "Detroit", "Livonia", "Garden City" };

    string[] studentFood = new string[] { "Cookies", "Brownies", "Hotdogs", "Chips" };

    Console.WriteLine("Pleae select the number of the student you would like more info on.");
    int userInput = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(studentName[userInput - 1]);


    bool tryAgain;
    tryAgain = false;
    do
    {
        Console.WriteLine("What information would you like displayed? Hometown or Favorite Food? Press 1 for Hometown and 2 for Favorite Food.");
        int displaySelect = Convert.ToInt32(Console.ReadLine());
        if (displaySelect == 1)
        {
            Console.WriteLine($"{studentName[userInput - 1]}'s hometown is {studentHometown[userInput - 1]}.");
            tryAgain = false;
        }
        else if (displaySelect == 2)
        {
            Console.WriteLine($"{studentName[userInput - 1]}'s favorite food is {studentFood[userInput - 1]}.");
            tryAgain = false;
        }
        else
        {
            Console.WriteLine("This is not a 1 or 2 please try again.");
            tryAgain = true;
        }
    }
    while (tryAgain = true);
    Console.WriteLine("Would you like to learn about another student? (y/n)?");
    string input = Console.ReadLine();
    goAgain = input.ToLower() == "y";
} while (goAgain == true);
Console.WriteLine("Thank you for learning about the students.");
Console.ReadKey();