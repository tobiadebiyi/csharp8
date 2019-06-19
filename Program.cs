using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Test.CSharp8
{
  class Program
  {
    static void Main(string[] args)
    {
      foreach (var _ in ValuesAsync())
      {
        Console.WriteLine(_);
      }

      ITrendy trendy = new Outdated();
      Console.WriteLine($"{trendy.Can_walk()} {trendy.Take_a_selfie()}");

      trendy = new Current();
      Console.WriteLine($"{trendy.Can_walk()} {trendy.Take_a_selfie()}");
    }

    public static IEnumerable<string> ValuesAsync()
    {
      return new List<string> {
      "hello",
      "world",
      "my",
      "pips"
      };
    }
  }
}
