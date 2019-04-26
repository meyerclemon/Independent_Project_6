using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    // public void WordCounteConstructor_CreatesInstanceOfWordCounter_WordCounter()
    public void IsWordCounter_NumberDivisibleByFour_True()
    {
      WordCounter testWordCounter = new WordCounter();
      Assert.AreEqual(true, testWordCounter.IsWordCounter(2012));
      // WordCounter newWordCounter = new WordCounter("","");
      // Assert.AreEqual(typeof(WordCounter), newWordCounter.GetType());
    }
  }
}
