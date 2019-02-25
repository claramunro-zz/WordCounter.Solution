using System;

namespace WordCounter.Models

{
  public class WordCounterGame

  {
    private int _wordCount;
    private string _inputSentence;
    private string _inputWord;


    public string GetSentence() { return _inputSentence; }
    public string GetWord() { return _inputWord; }
    public int GetWordCount() { return _wordCount; }

   public WordCounterGame(string inputSentence, string inputWord, int wordCount)
   {
     _wordCount = wordCount;
     _inputWord = inputWord;
     _inputSentence = inputSentence;
   }

    public int DoWordsMatch(string inputSentence, string inputWord, int wordCount)
    {
      string[] split = inputSentence.Split(' ');
      
      foreach (var word in split)
      {
        if (inputWord == word)
        {
          wordCount++;
        }
      }
      _wordCount = wordCount;
      return _wordCount;
      }
  }
}