using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounterGame.Controllers;
using WordCounterGame.Models;

namespace WordCounterGame.Tests
{
    [TestClass]
    public class WordCounterGameControllerTest
    {
        [TestMethod]
        public void IndexWordCounterGame_ReturnsCorrectViewPage_True()
        {
            WordCounterGameController controller = new WordCounterGameController();
            ActionResult indexView = controller.Index();
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }

        [TestMethod]
        public void New_ReturnsCorrectViewPage_True()
        {
            WordCounterGameController controller = new WordCounterGameController();
            ActionResult indexView = controller.New();
            Assert.IsInstanceOfType(indexView, typeof(ViewResult));
        }      
    }
}