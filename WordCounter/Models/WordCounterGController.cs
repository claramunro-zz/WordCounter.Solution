using System;

namespace WordCounter.Models

{
  public class WordCounterG

  {
    private int _wordCount;
    private string _inputSentence;
    private string _inputWord;


    // makes private words public
   public WordCounterG(string inputSentence, string inputWord, int wordCount)
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
      
      return wordCount;

      }
  }
}