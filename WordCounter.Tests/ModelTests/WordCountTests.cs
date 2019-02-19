using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCountTests
  {

    [TestMethod]
    public void DoWordsMatch_InputAs1Character_True()
    {
      string inputSentence = "c";
      string inputWord = "c";
      int wordCount = 0;

      MakeWordsPublic newMakeWordsPublic = new MakeWordsPublic (inputSentence, inputWord, wordCount);

      Assert.AreEqual(1, newMakeWordsPublic.DoWordsMatch(inputSentence, inputWord, wordCount));
    }


    [TestMethod]
    public void DoWordsMatch_InputAs2Character_True()
    {
      string inputSentence = "clara c is c";
      string inputWord = "c";
      int wordCount = 0;

      MakeWordsPublic newMakeWordsPublic = new MakeWordsPublic (inputSentence, inputWord, wordCount);

      Assert.AreEqual(2, newMakeWordsPublic.DoWordsMatch(inputSentence, inputWord, wordCount));
    }

    }
  }