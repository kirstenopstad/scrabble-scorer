namespace ScrabbleScorer.Models
{
  public class ScoreWord
  {
    public string[] wordArray { get; set; }

    // properties, constructors, methods, etc. go here
    public ScoreWord(string userInput)
    {
      wordArray = userInput.Split("");
    }

    public int ReturnScore() 
    {
      return 3;
    }
  }
}
