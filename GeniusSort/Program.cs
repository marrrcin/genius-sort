using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeniusSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new List<int> {9,7,6,1,1,1,2,4,5,3};
            Genius.Sort(array);
            Console.ReadKey();
        }
    }
}
