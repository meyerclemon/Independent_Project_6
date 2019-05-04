using System;
using System.Collections.Generic;


namespace WordCounter.Models
{
    public class RepeatCounter
  {
      //Test: Constructor_CreateInstanceOfRepeatCounter_RepeatCounter
        private string _word;
        private string _sentence;
        private string[] _wordArray;

        public RepeatCounter(string word, string sentence)
        {
          //Test: CaseChecker_ChangeToLowerCase_Count
          _word = word.ToLower();
          _sentence = sentence;
          _wordArray = sentence.ToLower().Split(' ', ',', '.', '!', ':', ';', '/', '?');

        }

        //Test: Constructor_SplitSentenceIntoWordArray_WordArray
        public string[] SplitSentence()
        {
          return _wordArray;
        }

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
