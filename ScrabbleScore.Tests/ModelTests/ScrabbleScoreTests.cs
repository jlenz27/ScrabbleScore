using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
    [TestClass]
    public class InputTest
    {
    [TestMethod]
  
  public void ScorerConstructor_ReturnValueOfASingleChar_Int()
  {
    GameResult newScore = new GameResult();
     string input = "A";
      int result =GameResult.LetterScore(input);
      Assert.AreEqual(1, result);
  }
    
    [TestMethod]
  
  public void ScorerConstructor_ReturnValueOfAWord_Int()
  {
    GameResult newScore = new GameResult();
      string input = "ghost";
      int result = GameResult.LetterScore(input);
      Assert.AreEqual(9, result);
  }}
}