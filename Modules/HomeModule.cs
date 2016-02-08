using Nancy;
using System.Collections.Generic;

namespace MadLibs
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      wordBank word = new wordBank();
      word.add( "Person1", "Person1");
      word.add( "Person2", "Person2");
      word.add( "Animal", "Animal");
      word.add( "Exclamation", "Exclamation");
      word.add( "Verb", "Verb");
      word.add( "Noun", "Noun");
      Get["/form"] = _ => {

        return View["form.html", word];
      };
      Get["/"] = _ => "Whatever";
      Get["/madlib"] = _ => {
        word.Person1 = Request.Query["Person1"];
        word.Person2 = Request.Query["Person2"];
        word.Animal = Request.Query["Animal"];
        word.Exclamation = Request.Query["Exclamation"];
        word.Verb = Request.Query["Verb"];
        word.Noun = Request.Query["Noun"];
        return View["madlib.html", word];
      };
    }
  }
}
