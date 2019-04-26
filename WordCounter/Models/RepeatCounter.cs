namespace WordCounter.Models
{
    public class WordItem
    {

      private string _wordInput;

      public WordItem(string wordInput)
      {
        _wordInput = wordInput;
      }
      public string GetWordInput()
      {
        return _wordInput;
      }
      public void SetWordInput(string newWordItem)
      {
        _wordInput = newWordItem;
      }
//All good above

    }
}
