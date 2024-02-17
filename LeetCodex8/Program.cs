using System.Diagnostics;
using LeetCodex8.Easy;
using LeetCodex8.Problems;

var stopwatch = new Stopwatch();
stopwatch.Start();

ProblemsEasy.PTwoSum();

Console.WriteLine($"\nTempo passadow: {stopwatch.Elapsed}");
stopwatch.Stop();
