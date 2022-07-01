using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace CollectionPerformance
{
    public class Benchmarks
    {
        private List<int> _list = new List<int>();
        private LinkedList<int> _linkedList = new LinkedList<int>();

        public Benchmarks()
        {
            for(int i = 0; i < 10000; i++)
            {
                _list.Add(i);
                _linkedList.AddLast(i);
            }
        }

        [Benchmark]
        public int ForWithList()
        {
            int sum = 0;

            for(int i = 0; i < _list.Count(); ++i)
            {
                sum += _list.ElementAt(i);
            }

            return sum;
        }

        [Benchmark]
        public int ForWithLinkedList()
        {
            int sum = 0;

            for (int i = 0; i < _linkedList.Count(); ++i)
            {
                sum += _linkedList.ElementAt(i);
            }

            return sum;
        }

        [Benchmark(Baseline = true)]
        public int ForeachWithList()
        {
            int sum = 0;

            foreach (var i in _list)
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int ForeachWithLinkedList()
        {
            int sum = 0;

            foreach (var i in _linkedList)
            {
                sum += i;
            }

            return sum;
        }
    }
}
