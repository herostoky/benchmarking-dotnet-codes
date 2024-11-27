using BenchmarkDotNet.Running;
using Benchmarking;

Console.WriteLine("Hello, World!");

// BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
BenchmarkRunner.Run<ForAndForeach>();
