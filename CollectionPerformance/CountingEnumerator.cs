using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPerformance
{
    public class CountingEnumerator<T> : IEnumerator<T>
    {
        public int MoveCount { get; private set; }
        public static int TotalMoveCount { get; private set; }

        private IEnumerator<T> _inner;

        public CountingEnumerator(IEnumerator<T> inner)
        {
            _inner = inner;
        }

        public T Current => _inner.Current;

        object IEnumerator.Current => _inner.Current!;

        public void Dispose()
        {
            Console.WriteLine($"MoveNext() called {MoveCount} times.");

            _inner.Dispose();
        }

        public bool MoveNext()
        {
            ++MoveCount;
            ++TotalMoveCount;

            return _inner.MoveNext();
        }

        public void Reset() => _inner.Reset(); 
    }
}
