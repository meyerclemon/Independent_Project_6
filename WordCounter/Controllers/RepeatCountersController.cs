using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class RepeatCountersController : Controller
  {
      [HttpGet("/repeatcounters")]
      public ActionResult Index()
      {
          return View();
      }

      [HttpPost("/repeatcounters")]
      public ActionResult Create(string word, string sentence)
      {
          RepeatCounter counter = new RepeatCounter(word, sentence);
          return View("Show", counter);
      }

      [HttpGet("/repeatcounters/new")]
      public ActionResult New()
      {
          return View();
      }

      [HttpGet("/repeatcounters/show")]
      public ActionResult Show()
      {
          return View();
      }
  }
}
