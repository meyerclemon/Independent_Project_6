using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTest
    {
        [TestMethod]
        public void WordCountConstructor_CreateInstanceOfWordCounter_Word()
        {
          WordCounter newWordCounter = new WordCounter("", "");
          Assert.AreEqual(typeof(WordCounter), newWordCounter.GetType());
        }

    }
}
