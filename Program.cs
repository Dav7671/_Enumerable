using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Enumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 125, 25, 521, 512, 521, 2, 42 };

            int[] arr = new int[] { 42, 213, 232, 423, 32, 3, 2, 32, 2 };
            int[] arr2 = new int[] { 421, 23, 42, 42, 34, 53, 7, 3, 43, 2 };

            var res = _Enumerable.Where<int>(arr, item => item % 2 == 1);
            var res1 = _Enumerable.Take<int>(arr, 5);
            var res2 = _Enumerable.Union<int>(arr, list);
            var res3 = _Enumerable.Union<int>(arr, arr2);
            var res4 = _Enumerable.Reverse<int>(arr2);
            var res5 = _Enumerable.Last<int>(list);
            var res6 = _Enumerable.Count<int>(arr);
           
        }
    }
}
