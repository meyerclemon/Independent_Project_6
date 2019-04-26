using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordItemTest
    {
        [TestMethod]
        public void WordItemConstructor_CreateInstanceOfWordItem_WordItem()
        {
          WordItem newWordItem = new WordItem("","");
          Assert.AreEqual(typeof(WordItem), newWordItem.GetType());
        }

        [TestMethod]
        public void GetWordInput_SetWordInput_String()
        {
          string wordInput = "test";
          WordItem newWordItem = new WordItem(wordInput, "");
          string result = newWordItem.GetWordInput();
          Assert.AreEqual(wordInput, result);
        }

        [TestMethod]
        public void SetWordInput_SetWordInput_String()
        {
          string wordInput = "test";
          WordItem newWordItem = new WordItem(wordInput, "");
          string updatedWordInput = "testing";
          newWordItem.SetWordInput(updatedWordInput);
          string result = newWordItem.GetWordInput();
          Assert.AreEqual(updatedWordInput, result);
        }
//All good above
        [TestMethod]
        public void GetSentenceInput_GetSentenceInput_String()
        {
            string sentenceInput = "I am still testing";
            WordItem newWordItem = new WordItem("", sentenceInput);
            Assert.AreEqual(sentenceInput, newWordItem.GetSentenceInput());
        }

        [TestMethod]
        public void SetSentenceInput_SetSentenceInput_String()
        {
            string sentenceInput = "I am still testing";
            WordItem newWordItem = new WordItem("", sentenceInput);
            string updatedSentenceInput = "I will be testing forever";
            newWordItem.SetSentenceInput(updatedSentenceInput);
            string result = newSentenceItem.GetSentenceInput();
            Assert.AreEqual(updatedSentenceInput, newWordItem.GetSentenceInput());
        }
    }
}
