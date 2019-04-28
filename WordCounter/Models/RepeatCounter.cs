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
        //End Test: Constructor_SplitSentenceIntoWordArray_WordArray

        //Test: Counter_ReturnNumberOfRepeatedWords_Int
        public int CountWords()
        {
          int count = 0;
          foreach(string word in _wordArray)
          {
            if(word == _word)
            {
              count++;
            }
          }
          return count;
        }
    }
}
