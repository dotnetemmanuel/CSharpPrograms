// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;
using System.Security.Cryptography.X509Certificates;
int wins = 0;
int losses = 0;
string input;

Console.WriteLine("#####    ROCK, PAPER, SCISSORS   #####\n");

static void play(string input, int wins, int losses)
{
    Random random = new Random();
    var list = new List<string> { "Rock", "Paper", "Scissors" };
    int index = random.Next(list.Count);

    Console.WriteLine("The computer plays " + list[index]);
    //LOSS    
    if ((input.Equals("r") && list[index].Equals("Paper")) || (input.Equals("p") && list[index].Equals("Scissors")) || (input.Equals("s") && index.Equals("Rock")))
    {
        Console.WriteLine("You lose!");
        losses++;
        Console.WriteLine("Losses: " + losses);
    }

    //WIN
    if ((input.Equals("r") && list[index].Equals("Scissors")) || (input.Equals("p") && list[index].Equals("Rock")) || (input.Equals("s") && list[index].Equals("Paper")))
    {
        Console.WriteLine("You win!");
        wins++;
        Console.WriteLine("Wins: " + wins);
    }

    //TIE
    if ((input.Equals("r") && list[index].Equals("Rock")) || (input.Equals("p") && list[index].Equals("Paper")) || (input.Equals("s") && list[index].Equals("Scissors")))
    {
        Console.WriteLine("This is a tie. Play again.");
    }
}



while (wins < 3 || losses < 3)
{
    Console.WriteLine("Please enter one of the following:\n\n(R)ock, (P)aper, (S)cissors or (E)xit");
    input = Console.ReadLine();

    play(input, wins, losses);
    
    if (wins == 3)
        {
            Console.WriteLine("You win the game!");
        }

    if (losses == 3)
        {
            Console.WriteLine("Game Over!");
        }
}



