# json2.cs

Port of https://github.com/douglascrockford/JSON-js to CSharp

```csharp
using json2;
...
dynamic json = JSON.Parse(@"{""name"": ""fred"", ""active"": true, ""id"": 42}");
Console.WriteLine("Name = "+json.name);

json.active = false;

string str = JSON.Stringify(json, 2);
Console.WriteLine(str);

```

Result:
```json
{
  "name": "fred",
  "active": false,
  "id": 42
}
```

### Unity

version jsonx is built for compatability with unity's version of CSharp - 2.6.5+


```csharp
using UnityEngine;
using jsonx;
...

var json = (JSONObject)JSON.Parse(@"{""name"": ""fred"", ""active"": true, ""id"": 42}");
Debug.Log("Name = "+json["name"]);

json["active"] = false;

string str = JSON.Stringify(json, 2);
Debug.Log(str);
```

# MIT License

Copyright (c) 2015 Bruce Davidson &lt;darkoverlordofdata@gmail.com&gt;

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
'Software'), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED 'AS IS', WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

