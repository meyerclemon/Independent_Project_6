using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
      [HttpGet("/wordcount")]
      public ActionResult Index()
      {
          return View();
      }

      [HttpGet("/wordcount/new")]
      public ActionResult New()
      {
          return View();
      }

      [HttpPost("/wordcount")]
      public ActionResult Create(string word, string sentence)
      {
          RepeatCounter counter = new RepeatCounter(word, sentence);
          return View("Show", counter);
      }

        [HttpGet("/wordcount/show")]
        public ActionResult Show()
        {
            return View();
        }

    }
}
