namespace WordCounter
{
    public class Word
    {
        private string _wordInput;

        public Word(string wordInput)
        {
            _wordInput = wordInput;
        }
        public string GetWordInpution()
        {
        return _wordInput;
        }


    }
    public class Sentence
    {
        private string _sentenceInput;

        public Sentence(string sentenceInput)
        {
            _sentenceInput = sentenceInput;
        }
        public string GetSentenceInpution()
         {
             return _sentenceInput;
         }
    }
}
