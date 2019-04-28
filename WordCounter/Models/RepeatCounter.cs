using System.Collections.Generic;

namespace WordCounter
{
    public class RepeatCounter
  {
      //Test: Constructor_CreateInstanceOfRepeatCounter_RepeatCounter
        private string _word;
        private string _sentence;
        private string[] _wordArray;

        public RepeatCounter(string word, string sentence)
        {
          _word = word;
          _sentence = sentence;
          _wordArray =sentence.Split(' ');

        }
        //End Test: Constructor_CreateInstanceOfRepeatCounter_RepeatCounter

        //Test: Constructor_SplitSentenceIntoWordArray_WordArray
        public string[] SplitSentence()
        {
          return _wordArray;
        }
    }
}
