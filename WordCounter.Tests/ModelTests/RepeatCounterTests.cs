using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {
        [TestMethod]
        public void Constructor_CreateInstanceOfRepeatCounter_RepeatCounter()
        {
          RepeatCounter testRepeatCounter = new RepeatCounter("word", "sentence");
          Assert.AreEqual(typeof(RepeatCounter), testRepeatCounter.GetType());
        }
        [TestMethod]
        public void Constructor_SplitSentenceIntoWordArray_WordArray()
        {
          string word = "word";
          string sentence = "word in a sentence";
          string[] expectedResult = {"word","in","a","sentence"};
          RepeatCounter testRepeatCounter = new RepeatCounter (word, sentence);
          CollectionAssert.AreEqual(testRepeatCounter.SplitSentence(), expectedResult);
        }

    }
}
