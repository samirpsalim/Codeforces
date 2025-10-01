using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF2137
{
    internal class _2137A
    {
        public void Answer()
        {
            var t = int.Parse(Console.ReadLine());

            int k, x;

            for (int i = 0; i < t; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(v => int.Parse(v)).ToList();

                k = input[0];
                x = input[1];

                Console.WriteLine((int)(Math.Pow(2, k) * x));
            }
        }

    }
}

//int t, n;

//t= int.Parse(Console.ReadLine());

//foreach(var i in Enumerable.Range(0,t))
//{
//    n = int.Parse(Console.ReadLine());

//    var a = Console.ReadLine().Split(' ').Select(i => int.Parse(i));

//    var b = new HashSet<int>(a);

//    if (b.Count == a.Count()) Console.WriteLine("NO");
//    else Console.WriteLine("YES");
//}
