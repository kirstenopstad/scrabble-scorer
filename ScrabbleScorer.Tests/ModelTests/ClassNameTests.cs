using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;
using System;
using System.Collections.Generic;

namespace ScrabbleScorer.Tests
{
  [TestClass]
  public class ClassNameTests
  {
    [TestMethod]
    public void ScoreWordConstructor_CreatesScoreWord_ScoreWord()
    {
      //Act
      ScoreWord word = new ScoreWord("");
      //Assert
      Assert.AreEqual(typeof(ScoreWord), word.GetType());
    }

    [TestMethod]
    // Test methods will go here
    public void StoreInput_TakeUserInputAndStoreAsArray_ArrayOfLetters()
    {
      // Arrange
      string userInput = "hello";

      // Act
      ScoreWord score = new ScoreWord(userInput);

      // Assert
      CollectionAssert.AreEqual(new char[] {'H', 'E', 'L', 'L', 'O'}, score.wordArray);
    }

    [TestMethod]
    public void GetLetterScore_ReturnScoreOfSingleLetterOnes_LetterScore()
    {
      //Arrange // check all 1-point letters
      List<string> list = new List<string> {"A", "E", "I", "O", "U", "L", "N", "R", "S", "T"} ;
      //Act
      foreach (string letter in list)
      {
        ScoreWord score = new ScoreWord(letter);
        //Assert
        Assert.AreEqual(1, score.ReturnScore());
      }      
    }

        [TestMethod]
    public void GetLetterScore_ReturnScoreOfSingleLetterTwos_LetterScore()
    {
      //Arrange // check all 2-point letters
      List<string> list = new List<string> {"D", "G"} ;
      //Act
      foreach (string letter in list)
      {
        ScoreWord score = new ScoreWord(letter);
        //Assert
        Assert.AreEqual(2, score.ReturnScore());
      }      
    }

    [TestMethod]
    public void GetLetterScore_ReturnScoreOfSingleLetterThrees_LetterScore()
    {
      //Arrange // check all 3-point letters
      List<string> list = new List<string> {"B", "C", "M", "P"} ;
      //Act
      foreach (string letter in list)
      {
        ScoreWord score = new ScoreWord(letter);
        //Assert
        Assert.AreEqual(3, score.ReturnScore());
      }      
    }

    [TestMethod]
    public void GetLetterScore_ReturnScoreOfSingleLetterFours_LetterScore()
    {
      //Arrange // check all 4-point letters
      List<string> list = new List<string> {"F", "H", "V", "W", "Y"} ;
      //Act
      foreach (string letter in list)
      {
        ScoreWord score = new ScoreWord(letter);
        //Assert
        Assert.AreEqual(4, score.ReturnScore());
      }      
    }

    [TestMethod]
    public void GetLetterScore_ReturnScoreOfSingleLettersFive_LetterScore()
    {
      //Arrange // check all 5-point letters
      List<string> list = new List<string> {"K"} ;
      //Act
      foreach (string letter in list)
      {
        ScoreWord score = new ScoreWord(letter);
        //Assert
        Assert.AreEqual(5, score.ReturnScore());
      }      
    }

    [TestMethod]
    public void GetLetterScore_ReturnScoreOfSingleLetterEight_LetterScore()
    {
      //Arrange // check all 8-point letters
      List<string> list = new List<string> {"J", "X"} ;
      //Act
      foreach (string letter in list)
      {
        ScoreWord score = new ScoreWord(letter);
        //Assert
        Assert.AreEqual(8, score.ReturnScore());
      }      
    }

    [TestMethod]
    public void GetLetterScore_ReturnScoreOfSingleLetterTen_LetterScore()
    {
      //Arrange // check all 10-point letters
      List<string> list = new List<string> {"Q", "Z"} ;
      //Act
      foreach (string letter in list)
      {
        ScoreWord score = new ScoreWord(letter);
        //Assert
        Assert.AreEqual(10, score.ReturnScore());
      }      
    }

    [TestMethod]
    public void ReturnScore_TakeUserInputAndReturn_Score()
    {
      // Arrange
      string userInput = "hello";
      int total = 0;

      // Act
      ScoreWord score = new ScoreWord(userInput); //8
      ScoreWord zulu = new ScoreWord("zulu");
      ScoreWord joker = new ScoreWord("joker");
      ScoreWord kangaroo = new ScoreWord("kangaroo");
      ScoreWord fox = new ScoreWord("fox");
      ScoreWord box = new ScoreWord("box");
      List<ScoreWord> list = new List<ScoreWord>();
      list.Add(score);
      list.Add(zulu);
      list.Add(joker);
      list.Add(kangaroo);
      list.Add(fox);
      list.Add(box);

      // Assert
      foreach (var item in list)
      {
        total += item.ReturnScore();
      }
      Assert.AreEqual( 75, total);
    }

    [TestMethod]
    public void ReturnScore_TakeUserInputOfNothing_0Score()
    {
      // Arrange
      string userInput = "";

      // Act
      ScoreWord score = new ScoreWord("");
      
      // Assert
      Assert.AreEqual(0, score.ReturnScore());
    }

    [TestMethod]
    public void ReturnScore_TakeUserInputOfNonAlpha_0Score()
    {
      // Arrange
      string userInput = "$";

      // Act
      ScoreWord score = new ScoreWord("$");

      // Assert
      Assert.AreEqual(0, score.ReturnScore());
    }
  }
}