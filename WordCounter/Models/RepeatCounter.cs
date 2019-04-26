namespace WordCounter.Models
{
    public class WordItem
    {

      private string _wordInput;
      private string _sentenceInput;

      public WordItem(string wordInput, string sentenceInput)
      {
        _wordInput = wordInput;
        _sentenceInput = sentenceInput;
      }
      public string GetWordInput()
      {
        return _wordInput;
      }
      public void SetWordInput(string newWordInput)
      {
        _wordInput = newWordInput;
      }
//All good above
      public string GetSentenceInput()
        {
            return _sentenceInput;
        }
        public void SetSentenceInput(string newSentenceInput)
        {
            _sentenceInput = newSentenceInput;
        }
    }
}
