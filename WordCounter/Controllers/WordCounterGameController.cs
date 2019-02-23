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
    public ActionResult Create(string inputWord, string inputSentence, int wordCount)
    {
      WordCounterGame thisGame = new WordCounterGame(inputWord, inputSentence, wordCount);
      return View("Index", thisGame);
    }
  }
}