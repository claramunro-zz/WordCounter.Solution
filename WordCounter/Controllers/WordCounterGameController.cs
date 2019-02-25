using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounterGame.Models;


namespace WordCounterGame.Controllers

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
      WordCounterGame1 thisGame = new WordCounterGame1(inputSentence, inputWord, wordCount);
      thisGame.DoWordsMatch(inputSentence, inputWord, wordCount);
      return View("Index", thisGame);
    }
  }
}