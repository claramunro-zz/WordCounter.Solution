using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCountTests
  {

Behavior 1: Takes wordInput of single letter & a single letter sentence & returns wordCount

Input: "c" and "c"
Output: "1"
This is the simplest behavior because wordInput is only one letter and sentenceInput is only one letter.

Behavior: Takes wordInput of single letter & two single letter "sentence" & returns wordCount

Input: "c" and "c c"
Output: "2"
This would be the next behavior because wordInput is only one letter and sentenceInput is two "words".

Behavior: Takes wordInput of word & sentence & returns wordCount

Input: "cat" and "The cat in the hat"
Output: "1"
This would be the next behavior because following 1 letter is one word & sentence input is looking for word.

Behavior: Takes wordInput of word & sentence with word as part of another larger word (cat & cathedral) & returns correct wordCount

Input: "cat" and "The cat went to the cathedral"
Output: "1"
This is the final behavior, word (cat) appears in sentence & also characters within the word appear within another word (cathedral).
    }
  }