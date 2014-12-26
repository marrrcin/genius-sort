using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GeniusSort
{
    public static class Genius
    {
        public static void Sort(List<int> toSort)
        {
            var threads = new List<Thread>();
            while (toSort.Count > 0)
            {
                var num = toSort.Last();
                toSort.RemoveAt(toSort.Count-1);
                var sorter = new Thread(() =>
                {
                    Thread.Sleep(num * 1000);
                    Console.Write(num + " ");
                });
                threads.Add(sorter);
                sorter.Start();
            }
            threads.ForEach(t=>t.Join());
            Console.Write("done!");
        }
    }
}
