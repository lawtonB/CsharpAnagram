using Nancy;
using System.Collections.Generic;
using Anagrams;
using System;

namespace Anagrams
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
    Get["/"] = _ => View["index.cshtml"];
    Post["/printout"] = _ =>
      {
        Anagram AnagramObject = new Anagram(Request.Form["inputNumberOne"], Request.Form["inputNumberTwo"]);
        string newString = AnagramObject.CompareInputs();
        return View["printout.cshtml", newString];
      };
    }
  }
}

// (16,34): DNX,Version=v4.5.1 error CS0029: Cannot implicitly convert type 'bool' to 'System.Collections.Generic.List<string>'
