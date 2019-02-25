using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounterGame.Models;

// namespace WordCounterGame.Tests
// {
//   [TestClass]
//   public class WordCounterGame
//   {

//     [TestMethod]
//     public void DoWordsMatch_InputAs1Character_True()
//     {
//       string inputSentence = "c";
//       string inputWord = "c";
//       int wordCount = 0;

//       WordCounterGame1 thisGame = new WordCounterGame1 (inputSentence, inputWord, wordCount);

//       Assert.AreEqual(1, thisGame.DoWordsMatch(inputSentence, inputWord, wordCount));
//     }


//     [TestMethod]
//     public void DoWordsMatch_InputAs2Character_True()
//     {
//       string inputSentence = "clara c is c";
//       string inputWord = "c";
//       int wordCount = 0;

//       WordCounterGame1 thisGame = new WordCounterGame1 (inputSentence, inputWord, wordCount);

//       Assert.AreEqual(2, thisGame.DoWordsMatch(inputSentence, inputWord, wordCount));
//     }

//     [TestMethod]
//     public void DoWordsMatch_InputAsWord2Character_True()
//     {
//       string inputSentence = "clara c is clara clara";
//       string inputWord = "clara";
//       int wordCount = 0;

//       WordCounterGame1 thisGame = new WordCounterGame1 (inputSentence, inputWord, wordCount);

//       Assert.AreEqual(3, thisGame.DoWordsMatch(inputSentence, inputWord, wordCount));
//     }

//     }
//   }