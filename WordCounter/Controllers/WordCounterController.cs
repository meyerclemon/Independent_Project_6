using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
      [HttpGet("/repeatcounter")]
      public ActionResult Index()
      {
          return View();
      }

      [HttpPost("/repeatcounter")]
      public ActionResult Create(string word, string sentence)
      {
          if(word == null || sentence == null)
          {
              string model = "Please enter search criteria.";
              return View("New", model);
          }

          RepeatCounter counter = new RepeatCounter(word, sentence);
          return View("Show", counter);
      }

      [HttpGet("/repeatcounter/new")]
      public ActionResult New()
      {
          return View();
      }

      [HttpGet("/repeatcounter/show")]
      public ActionResult Show()
      {
          return View();
      }
  }
}
