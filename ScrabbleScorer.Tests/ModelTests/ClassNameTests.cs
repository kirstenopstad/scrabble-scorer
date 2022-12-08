using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer;

namespace ScrabbleScorer.Tests
{
  [TestClass]
  public class ClassNameTests
  {
    [TestMethod]
    // Test methods will go here
    public void StoreInput_TakeUserInputAndStore_Word()
    {
      // Arrange
      string userInput = "hello";

      // Act
      ScoreWord score = new ScoreWord(userInput);

      // Assert
      Assert.AreEqual("hello", score.word);
    }
  }
}