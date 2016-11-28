using Nancy;
using System.Collections.Generic;
using PingPong.Objects;

namespace PingPong
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

        Get["/pingpong/form"] = _ => {
        return View["form.cshtml"];
      };

    }
  }
}
