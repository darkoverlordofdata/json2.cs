using System;
using System.Collections.Generic;
using jsonx;

namespace json {
  class MainClass {
    public static void Main(string[] args) {
      Console.WriteLine("json2 demo");

      try {
        string source;
        string s;

        source = @"{""name"": ""fred"", ""active"": true, ""id"": 42, ""scores"": [0, 1, 2], ""flags"": {""first"": false}}";
        Console.WriteLine("|"+source+"|");

        /*
        dynamic x = json2.JSON.Parse(source);

        Console.WriteLine("name: "+x.name);
        Console.WriteLine("active: "+x.active);
        Console.WriteLine("id: "+x.id);
        Console.WriteLine("score1: "+x.scores[0]);
        Console.WriteLine("score2: "+x.scores[1]);
        Console.WriteLine("score3: "+x.scores[2]);
        Console.WriteLine("flags.first: "+x.flags.first);

        x.scores[1] = x.scores[1]+1;

        s = json2.JSON.Stringify(x, "  ");
        Console.WriteLine("|"+s+"|");

        Console.WriteLine("name: "+x.name);
        Console.WriteLine("active: "+x.active);
        Console.WriteLine("id: "+x.id);
        Console.WriteLine("score1: "+x.scores[0]);
        Console.WriteLine("score2: "+x.scores[1]);
        Console.WriteLine("score3: "+x.scores[2]);
        Console.WriteLine("flags.first: "+x.flags.first);
        */

        var y = (JSONObject)JSON.Parse(source);
        Console.WriteLine("name: "+y["name"]);
        Console.WriteLine("active: "+y["active"]);
        Console.WriteLine("id: "+y["id"]);
        var score = (JSONArray)y["scores"];
        Console.WriteLine("score1: "+score[0]);
        Console.WriteLine("score2: "+score[1]);
        Console.WriteLine("score3: "+score[2]);
        score[1] = 42;

        Console.WriteLine("score1: "+JSON.Array(y["scores"])[0]);
        Console.WriteLine("score1: "+JSON.Array(y["scores"])[1]);
        Console.WriteLine("score1: "+JSON.Array(y["scores"])[2]);

        JSON.Array(y["scores"])[2] = 77;

        var flags = (JSONObject)y["flags"];
        Console.WriteLine(flags["first"]);
        Console.WriteLine(JSON.Object(y["flags"])["first"]);

        flags["first"] = false;
        s = JSON.Stringify(y, "  ");
        Console.WriteLine("|"+s+"|");



      } catch (Exception e) {
        Console.WriteLine(e.Message + e.StackTrace);
      }
    }
  }
}
