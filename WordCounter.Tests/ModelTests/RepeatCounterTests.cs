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
        [TestMethod]
        public void Counter_ReturnNumberOfRepeatedWords_Int()
        {
          string word = "test";
          string sentence = "this test is for testing how many times test appears";
          RepeatCounter testRepeatCounter = new RepeatCounter(word, sentence);
          Assert.AreEqual(2, testRepeatCounter.CountWords());
        }
    }
}
