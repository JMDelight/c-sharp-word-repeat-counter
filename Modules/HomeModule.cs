using Nancy;
using WordCounter.Objects;

namespace WordCounter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get ["/"] = _ => View ["index.cshtml"];

      Post ["/result"] = _ =>
      {
        RepeatCounter userRepeatCounter = new RepeatCounter(Request.Form["user-sentence-input"], Request.Form["user-word-to-check"]);
        return View["result.cshtml", userRepeatCounter];
      };
    }
  }

}
