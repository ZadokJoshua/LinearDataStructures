using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDataStructuresPackt1
{
    public class Pair<T>
    {
        public T First { get; }
        public T Second { get; }

        public Pair(T first, T second)
        {
            First = first;
            Second = second;
        }

        public void ReadPair() => Console.WriteLine($"First Pair: {First}, Second Pair: {Second}");
    }
}
