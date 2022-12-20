// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography.X509Certificates;
int wins = 0;
int losses = 0;
string input;

Console.WriteLine("#####    ROCK, PAPER, SCISSORS   #####\n");
while (wins < 3 || losses < 3)
{
    Console.WriteLine("Please enter one of the following:\n\n(R)ock, (P)aper, (S)cissors or (E)xit");
    input = Console.ReadLine();

    
    Random random = new Random();
    var list = new List<string> { "Rock", "Paper", "Scissors" };
    int index = random.Next(list.Count);

    Console.WriteLine("\nThe computer plays " + list[index]);

    //LOSS    
    if ((input.Equals("r") && list[index].Equals("Paper")) || (input.Equals("p") && list[index].Equals("Scissors")) || (input.Equals("s") && index.Equals("Rock")))
    {
        losses++;
        Console.WriteLine("You lose!");
        Console.WriteLine("Wins: " + wins);
        Console.WriteLine("Losses: " + losses + "\n");
    }

    //WIN
    if ((input.Equals("r") && list[index].Equals("Scissors")) || (input.Equals("p") && list[index].Equals("Rock")) || (input.Equals("s") && list[index].Equals("Paper")))
    {
        wins++;
        Console.WriteLine("You win!");
        Console.WriteLine("Wins: " + wins);
        Console.WriteLine("Losses: " + losses + "\n");
    }

    //TIE
    if ((input.Equals("r") && list[index].Equals("Rock")) || (input.Equals("p") && list[index].Equals("Paper")) || (input.Equals("s") && list[index].Equals("Scissors")))
    {
        Console.WriteLine("This is a tie. Play again.\n");
    }

    if (input.Equals("e"))
    {
        Console.Clear();
        return;
    }

    if(input != ("r") && input != ("p") && input != ("s") && input != ("e"))
    {
        Console.WriteLine("Wrong input, try again");
    }


    if (wins == 3)
        {
            Console.WriteLine("You win the game! Play again? Y/N.");
        if (Console.ReadLine().Equals("y"))
            {
              wins = 0;
            losses = 0;
              continue;
            }
        else
            Console.Clear();
            return;
        }

    if (losses == 3)
        {
            Console.WriteLine("Game Over! Play again? Y/N.");
        if (Console.ReadLine().Equals("y"))
        {
            wins = 0;
            losses = 0;
            continue;
        }
        else
            Console.Clear();
            return;
    }
}









