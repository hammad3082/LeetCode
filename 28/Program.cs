// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");


int StrStr(string haystack, string needle)
{
    int result = haystack.IndexOf(needle);
    return result;
}

Stopwatch stopwatch = new Stopwatch();

stopwatch.Start();

long memoryBefore = GC.GetTotalMemory(true);
Console.WriteLine(StrStr("", ""));

stopwatch.Stop();
long memoryAfter = GC.GetTotalMemory(true);

Console.WriteLine("Elapsed time in ticks: " + stopwatch.ElapsedTicks);
Console.WriteLine("Elapsed time in milliseconds: " + stopwatch.Elapsed.TotalMilliseconds + " ms");
Console.WriteLine("Memory used: " + (memoryAfter - memoryBefore) + " bytes");
