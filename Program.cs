using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Test.CSharp8
{
  class Program
  {
    static async Task Main(string[] args)
    {
      Console.WriteLine("");
      Console.WriteLine("____Async Streams___");
      Console.WriteLine("");

      await foreach (var v in ValuesAsync())
      {
        Console.WriteLine(v);
      }

      Console.WriteLine("");
      Console.WriteLine("____Default interface implementation___");
      Console.WriteLine("");

      IModel trendy = new Outdated();
      Console.WriteLine($"{trendy.Can_walk()}, {trendy.Take_a_selfie()}");

      trendy = new Current();
      Console.WriteLine($"{trendy.Can_walk()}, {trendy.Take_a_selfie()}");

      Console.WriteLine("");
    }

    public static async IAsyncEnumerable<string> ValuesAsync()
    {
      await Task.Delay(100);
      yield return "hello";
      yield return "world";
      yield return "my";
      yield return "pips";
    }
  }
}
