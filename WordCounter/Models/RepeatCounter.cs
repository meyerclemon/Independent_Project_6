namespace WordCounter.Models
{
    public class WordItem
    {

      private string _wordInput;
      private string _sentenceInput;
      private int _count;

      public WordItem(string wordInput, string sentenceInput, int count)
      {
        _wordInput = wordInput;
        _sentenceInput = sentenceInput;
        _count = count;
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

        // public int CheckIt (string wordInput, string sentenceInput)
        // {
        //   string[] sentenceArray = sentenceInput.ToLower().Split(' ','.',',');
        //   for (int i = 0; i < sentenceArray.Length; i++)
        //     {
        //       if (wordInput.ToLower() == sentenceArray[i])
        //       {
        //     _count++;
        //   }
        // }
        // return _count;
    }
}
