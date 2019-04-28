using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {
        [TestMethod]
        public void CounterConstructor_CreateInstanceOfRepeatCounter_RepeatCounter()
        {
          RepeatCounter testRepeatCounter = new RepeatCounter("word", "sentence");
          Assert.AreEqual(typeof(RepeatCounter), testRepeatCounter.GetType());
        }

        [TestMethod]
        public void CounterConstructor_SplitSentenceIntoWordArray_WordArray()
        {
          string word = "word";
          string sentence = "word in a sentence";
          string[] expectedResult = {"word","in","a","sentence"};

          RepeatCounter testRepeatCounter = new RepeatCounter (word, sentence);
          CollectionAssert.AreEqual(testRepeatCounter.SplitSentence(), expectedResult);
        }


        [TestMethod]
        public void WordCounter_ReturnNumberOfRepeatedWords_CountInt()
        {
          string word = "test";
          string sentence = "this test is for testing how many times test appears";

          RepeatCounter testRepeatCounter = new RepeatCounter(word, sentence);
          Assert.AreEqual(2, testRepeatCounter.CountWords());
        }

        [TestMethod]
        public void CaseChecker_ChangeToLowerCase_Count()
        {
          string word = "test";
          string sentence = "Test for testing occurrances of test.";
          RepeatCounter testRepeatCounter = new RepeatCounter(word, sentence);
          Assert.AreEqual(2, testRepeatCounter.CountWords());

        }
    }
}
