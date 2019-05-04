using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
      [HttpGet("/wordcount/new")]
      public ActionResult New()  {  return View();  }

      [HttpGet("/wordcount")]
      public ActionResult Index()  {  return View();  }

      [HttpPost("/wordcount")]
      public ActionResult Create(string word, string sentence)
      {
          RepeatCounter count = new RepeatCounter(word, sentence);
          return View("Show", count);
      }

        [HttpGet("/wordcount/show")]
        public ActionResult Show()
        {
            return View();
        }

    }
}
