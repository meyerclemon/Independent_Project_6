namespace WordCounter.Models
{
    public class WordItem
    {
//All good above
      private string _wordInput;

      public WordItem(string wordInput)
      {
        _wordInput = wordInput;

      }

      public string GetWordInput()
      {
        return _wordInput;
      }

    }
}
