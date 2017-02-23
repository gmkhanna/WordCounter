using Nancy;
using System;
using System.Collections.Generic;

namespace RepeatCounterApp
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/counted-words"] = _ => {
        RepeatCounter wordCount = new RepeatCounter(Request.Form["word"], Request.Form["text"]);
        int countedWords = wordCount.CountRepeats();
        return View["index.cshtml", countedWords];
      };
    }
  }
}
