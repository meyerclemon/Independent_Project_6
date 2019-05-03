using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
      [HttpGet("/wordCounter")]
      public ActionResult Index()
      {
          return View();
      }

      // [HttpGet("/wordCounter/new")]
      // public ActionResult New()
      // {
      //     return View();
      // }

  }
}
