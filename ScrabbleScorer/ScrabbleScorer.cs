using System;
using ScrabbleScorer.Models;

namespace ScrabbleScorer 
{
  public class Program
  {
    public static void Main() 
    {
      bool playAgain = true;
      while (playAgain)
      {
        Console.WriteLine("Enter a word to get it's scrabble score.");
        string input = Console.ReadLine();
        ScoreWord score = new ScoreWord(input);
        Console.WriteLine($"Your Scrabble score is : {score.ReturnScore()}");
        Console.WriteLine("Would you like to play again? (y/n)");
        string userInputAgain = Console.ReadLine();
        if (userInputAgain == "n")
        {
          playAgain = false;
        }
      }
    }
  }
}