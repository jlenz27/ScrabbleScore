using System;
using ScrabbleScore.Models;

namespace ScrabbleScore
{
    class Program
    {
        static void Main()
        {
      Console.WriteLine("-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-_-");
      Console.WriteLine("Enter a word to calculate your Scrabble score:");
      string word = Console.ReadLine();
      int scoreValue = GameResult.LetterScore(word);
      Console.WriteLine($"Your Scrabble score for '{word}' is {scoreValue}");
    }
  }
}
        
    

