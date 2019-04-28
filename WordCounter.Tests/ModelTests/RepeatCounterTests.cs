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
          RepeatCounter testRepeatCounter = new RepeatCounter ("word", "word in sentence");
          
        }
    }

}
