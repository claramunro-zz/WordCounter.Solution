using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;


namespace WordCounter.Controllers

{
  public class WordCounterGameController : Controller
  
  {
    [HttpGet("/game")]
    public ActionResult Index() { return View(); }

    [HttpGet("/game/new")]
    public ActionResult New() { return View(); }

    [HttpPost("/game")]
    public ActionResult Create(string inputSentence, string inputWord)
    {
      int wordCount = 0;
      WordCounterGame thisGame = new WordCounterGame(inputSentence, inputWord, wordCount);
      thisGame.DoWordsMatch(inputSentence, inputWord, wordCount);
      return View("Index", thisGame);
    }
  }
}