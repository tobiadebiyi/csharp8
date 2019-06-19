using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Test.CSharp8
{
  class Program
  {
    static async Task Main(string[] args)
    {
      await AsyncStreams();
      DefaultInterfaceImplementations();
      SwitchExpressions();
      RangesAndIndices();
    }

    private static void RangesAndIndices()
    {
      ConsoleSpace("Ranges and Indices");
      Index position1 = 3;
      Index position2 = ^2;

      var text = "1234567890";

      Console.WriteLine($"Range: {text[position1..position2]}");
      Console.WriteLine($"Forward: {text[position1]}");
      Console.WriteLine($"Backward: {text[position2]}");
    }

    private static async Task AsyncStreams()
    {
      ConsoleSpace("Async Streams");
      await foreach (var v in ValuesAsync())
      {
        Console.WriteLine(v);
      }
    }

    private static void DefaultInterfaceImplementations()
    {
      ConsoleSpace("Default interface implementation");
      IModel trendy = new Outdated();
      Console.WriteLine($"{trendy.Can_walk()}, {trendy.Take_a_selfie()}");

      trendy = new Current();
      Console.WriteLine($"{trendy.Can_walk()}, {trendy.Take_a_selfie()}");
    }

    private static void SwitchExpressions()
    {
      ConsoleSpace("Switch expressions");

      var personality = Personality.Optimist;
      var advice = personality switch
      {
        Personality.Percimist => "Live a little",
        Personality.Optimist => "Go on you!",
        _ => "Pick a side"
      };

      Console.WriteLine(advice);
    }

    public enum Personality
    {
      Percimist = 1,
      Optimist = 2
    }

    public static async IAsyncEnumerable<string> ValuesAsync()
    {
      await Task.Delay(100);
      yield return "say";
      yield return "hello";
      yield return "to";
      yield return "CSharp8";
    }

    public static void ConsoleSpace(string? section = null)
    {
      Console.WriteLine("");
      if (section != null) Console.WriteLine($"____{section}___");
      Console.WriteLine("");
    }
  }
}
