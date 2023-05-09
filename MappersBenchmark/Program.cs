using System;
using BenchmarkDotNet.Running;

namespace MappersBenchmark;

public class Program
{
    public static void Main(string[] args)
    {
        // var b = new MyBenchmark();
        // b.SetUp();
        // var result = b.Mapster_Single();
        // var results = b.Mapster_List();
        var summary = BenchmarkRunner.Run<MyBenchmark>();
    }
}