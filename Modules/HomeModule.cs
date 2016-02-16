using Nancy;
using Anagram.Objects;
using System.Collections.Generic;

namespace AnagramFront
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View ["index.cshtml"];
      //loads index view at root//

      Get["/other_page"] = _ => {
      return View["template.cshtml"];
      };
    }
  }
}
