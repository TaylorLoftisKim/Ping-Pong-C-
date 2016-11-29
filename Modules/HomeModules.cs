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

      Post["/pingpong/form"] = _ => {
        var userNumber = Request.Form["new-number"];
        PingPongGenerator myPingPong = new PingPongGenerator();
        myPingPong.Generator(userNumber);
        return View["display_form.cshtml", myPingPong];
      };
    }
  }
}
