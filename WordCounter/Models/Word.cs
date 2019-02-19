namespace WordCounter
{
  public class Word
  {
    private int _wordCount;
    private string _inputSentence;
    private string _inputWord;

    public int MatchCounter(string inputSentence, string inputWord, int wordCount)
    {
      string[] split = inputSentence.Split(' ');
      
      foreach (var word in split)
      {
        if (inputWord == word)
        {
          wordCount++;
        }
      }
      
      return wordCount;
      }

  }
}