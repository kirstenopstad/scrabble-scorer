using System.Text.RegularExpressions;
using System.Text;
using System.Collections.Generic;

namespace ScrabbleScorer.Models
{
  public class ScoreWord
  {
    public static Dictionary<string, int> dict = new Dictionary<string, int> 
    {
      {"AEIOULNRST", 1},
      {"DG", 2},
      {"BCMP", 3},
      {"FHVWY", 4},
      {"K", 5},
      {"JX", 8},
      {"QZ", 10}
    };
    public char[] wordArray { get; set; }

    // properties, constructors, methods, etc. go here
    public ScoreWord(string userInput)
    {
      userInput = userInput.ToUpper();
      wordArray = userInput.ToCharArray();
    }

    public int ReturnScore() 
    {
      int score = 0;
      for (int i = 0; i < wordArray.Length; i++)
      {
        foreach (KeyValuePair<string, int> item in dict)
        {
          if(item.Key.Contains(wordArray[i]))
          {
            score += item.Value;
            break;
          }
        }
      }
      return score;
    }
  }
}
