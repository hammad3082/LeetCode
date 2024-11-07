// See https://aka.ms/new-console-template for more information
using System.Text;
using System;
using System.Diagnostics;

// Measure memory before execution
long memoryBefore = GC.GetTotalMemory(true);

// Measure time taken
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

string word1 = "abcrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrr", word2 = "123456", result1 = "";
StringBuilder result = new StringBuilder();
int i = 0;
int j = 0;
int len = word1.Length> word2.Length?word1.Length:word2.Length;
        while (len-- != 0)
        {
            if (i < word1.Length)
            {
                result.Append(word1[i]);
                i++;
            }
            if (j < word2.Length)
            {
                result.Append(word2[j]);
                j++;
            }
            //len--;
        }
        string ssss = result.ToString();


stopwatch.Stop();
long memoryAfter = GC.GetTotalMemory(true);

// Display the results
Console.WriteLine("Result: " + ssss);
Console.WriteLine("Elapsed time in ticks: " + stopwatch.ElapsedTicks);
Console.WriteLine("Elapsed time in milliseconds: " + stopwatch.Elapsed.TotalMilliseconds + " ms");

Console.WriteLine("Time elapsed: " + stopwatch.ElapsedMilliseconds + " ms");
Console.WriteLine("Memory used: " + (memoryAfter - memoryBefore) + " bytes");
////------------------

//while (len != 0)
//{
//    if (i < word1.Length)
//    {
//        result += word1[i];
//        i++;
//    }
//    else
//    {
//        result += word2.Substring(j);
//        break;
//    }
//    if (j < word2.Length)
//    {
//        result += word2[j];
//        j++;
//    }
//    else
//    {
//        result += word1.Substring(i);
//        break;
//    }
//    len--;
//}
//----------------------------



//while (len != 0)
//{
//    if (i < word1.Length)
//    {
//        result += word1[i];
//        i++;
//    }
//    if (j < word2.Length)
//    {
//        result += word2[j];
//        j++;
//    }
//    len--;
//}
