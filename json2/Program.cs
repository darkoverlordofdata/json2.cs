using System;
using json2;

namespace json2 {
  class MainClass {
    public static void Main(string[] args) {
      Console.WriteLine("json2 demo");

      try {
        string s;
        s = @"{""name"": ""fred"", ""active"": true, ""id"": 42, ""scores"": [0, 1, 2], ""flags"": {""first"": false}}";
        Console.WriteLine("|"+s+"|");
        dynamic x = JSON.Parse(s);

        Console.WriteLine("name: "+x.name);
        Console.WriteLine("active: "+x.active);
        Console.WriteLine("id: "+x.id);
        Console.WriteLine("score1: "+x.scores[0]);
        Console.WriteLine("score2: "+x.scores[1]);
        Console.WriteLine("score3: "+x.scores[2]);
        Console.WriteLine("flags.first: "+x.flags.first);

        x.scores[1] = x.scores[1]+1;

        s = JSON.Stringify(x, "  ");
        Console.WriteLine("|"+s+"|");

        Console.WriteLine("name: "+x.name);
        Console.WriteLine("active: "+x.active);
        Console.WriteLine("id: "+x.id);
        Console.WriteLine("score1: "+x.scores[0]);
        Console.WriteLine("score2: "+x.scores[1]);
        Console.WriteLine("score3: "+x.scores[2]);
        Console.WriteLine("flags.first: "+x.flags.first);

      } catch (Exception e) {
        Console.WriteLine(e.Message + e.StackTrace);
      }


    }
  }
}
