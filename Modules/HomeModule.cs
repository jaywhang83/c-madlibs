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
      word.add( "Animal2", "Animal2");
      word.add( "Exclamation", "Exclamation");
      word.add( "Verb", "Verb");
      word.add( "Verb2", "Verb");
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
        word.Verb2 = Request.Query["Verb2"];
        word.Noun = Request.Query["Noun"];
        word.Animal2 = Request.Query["Animal2"];
        return View["madlib.html", word];
      };
    }
  }
}
