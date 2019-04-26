using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
    [TestClass]
    public class RepeatCounterTest
    {
        [TestMethod]
        public void WordCountConstructor_CreateInstanceOfWordCounter_Word()
        {
          RepeatCounter newRepeatCounter = new RepeatCounter("", "");
          Assert.AreEqual(typeof(RepeatCounter), newRepeatCounter.GetType());
        }

    }
}
