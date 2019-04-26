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
          WordItem newWordItem = new WordItem("");
          Assert.AreEqual(typeof(WordItem), newWordItem.GetType());
        }

        [TestMethod]
        public void GetWordInput_SetWordInput_String()
        {
          string wordInput = "booyah";
          WordItem newWordItem = new WordItem(wordInput);
          string result = newWordItem.GetWordInput();
          Assert.AreEqual(wordInput, result);
        }

        [TestMethod]
        public void SetWordInput_SetWordInput_String()
        {
          string wordInput = "booyah";
          WordItem newWordItem = new WordItem(wordInput);
          string updatedWordInput = "abooya";
          newWordItem.SetWordInput(updatedWordInput);
          string result = newWordItem.GetWordInput();
          Assert.AreEqual(updatedWordInput, result);
        }
//All good above
    }
}
