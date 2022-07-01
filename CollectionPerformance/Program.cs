using BenchmarkDotNet.Running;
using CollectionPerformance;
using System.Collections.Generic;
using System.Linq;

//BenchmarkRunner.Run<Benchmarks>();

var myList = new MyList<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

for(int i = 0; i < myList.Count(); ++i)
{
    System.Console.WriteLine(myList.ElementAt(i));
}

System.Console.WriteLine(CountingEnumerator<int>.TotalMoveCount);