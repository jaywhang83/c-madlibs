using System.Collections.Generic;

namespace MadLibs
{
  public class wordBank
  {
      public string Person1 { get; set; }
      public string Person2 { get; set; }
      public string Animal { get; set; }
      public string Exclamation { get; set; }
      public string Verb { get; set; }
      public string Noun { get; set; }
      public Dictionary<string, string> englishStuff;

      public wordBank()
      {
        englishStuff = new Dictionary<string,string>(){};
      }
      public void add(string key, string value)
      {
        englishStuff.Add(key, value);
      }
  }
}
