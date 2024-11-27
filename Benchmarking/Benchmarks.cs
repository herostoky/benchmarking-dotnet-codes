using System.Text;
using BenchmarkDotNet.Attributes;

namespace Benchmarking;

[MemoryDiagnoser]
[ShortRunJob] // <-- make it take less time 
public class StringAndStringBuilder
{
    [Params(5, 50, 500)] //<-- This is a parameter attribute
    public int N { get; set; }

    [Benchmark(Baseline = true)] // <-- this is the baseline
    public string StringJoin()
    {
        return string.Join(", ", Enumerable.Range(0, N).Select(i => i.ToString()));
    }

    [Benchmark(Baseline = true)]
    public string StringBuilderI()
    {
        var sb = new StringBuilder();
        for (var i = 0; i < N; i++)
        {
            sb.Append(i);
            sb.Append(", ");
        }
        return sb.ToString();
    }
}


[MemoryDiagnoser]
[ShortRunJob]
public class ForAndForeach
{
    private class Person
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
    }
    
    [Params(5, 50, 500)]
    public int N { get; set; }
    private Person[] _persons = [];

    [GlobalSetup]
    public void Setup()
    {
        _persons = GetPersons().ToArray();
    }

    IEnumerable<Person> GetPersons()
    {
        return Enumerable.Range(0, N).Select(i => new Person { Name = "P" + i, Age = i * 10 % 2  });
    }

    [Benchmark(Baseline = true)]
    public int ForeachLoop()
    {
        var sumAge = 0;
        foreach (var person in _persons)
        {
            sumAge += person.Age;
        }
        // Console.WriteLine(sumAge);
        return sumAge;
    }

    [Benchmark]
    public int ForILoop()
    {
        var sumAge = 0;
        for (var i = 0; i < _persons.Length; i++)
        {
            sumAge += _persons[i].Age;
        }
        // Console.WriteLine(sumAge);
        return sumAge;
    }
}