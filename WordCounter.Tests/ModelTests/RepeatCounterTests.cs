
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordTest
    {
        [TestMethod]
        public void WordConstrutor_CheckUserInputsWord_String()
        {
            Word newWord = new Word("testing");
            Assert.AreEqual(typeof(Word), newWord.GetType());
        }
        [TestMethod]
        public void GetWordInput_ReturnWordInput_String()
        {
            Word newWord = new Word("test");
            string result = newWord.GetWordInput();
            Assert.AreEqual(result, "test");
        }
        [TestMethod]
        public void GetSentenceInput_ReturnSentenceInput_String()
        {
            Sentence newSentence = new Sentence("Testing sentence");
            string result = newSentence.GetSentenceInput();
            Assert.AreEqual(result, "Testing sentence");
        }
    }
}
