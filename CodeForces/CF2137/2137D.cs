using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Leetcode.CodeForces.CF2137._2137D;

namespace Leetcode.CodeForces.CF2137
{
    internal class _2137D
    {
        private void Solve()
        {
            var t = int.Parse(Console.ReadLine());

            int n;

            for (int i = 0; i < t; i++)
            {
                n = int.Parse(Console.ReadLine());

                var b = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

                Dictionary<int, int> r = new Dictionary<int, int>();

                foreach (var num in b)
                {
                    if (r.ContainsKey(num)) r[num]++;
                    else r[num] = 1;
                }

                if (r.Any(i => i.Value % i.Key != 0)) Console.WriteLine(-1);
                else
                {
                    Console.WriteLine(string.Join(' ', GetResult(b, r)));
                }
            }
        }
        List<int> GetResult(int[] b, Dictionary<int, int> r)
        {
            Dictionary<int, GeneratedList> numbersByFrequency = new();

            int start = 1;

            int count;

            foreach (var kp in r)
            {
                count = kp.Value / kp.Key;
                numbersByFrequency.Add(kp.Key, new GeneratedList(0, Enumerable.Range(start, count).ToArray()));
                start += count;
            }

            List<int> a = new(b.Length);

            foreach (var num in b)
            {
                GeneratedList generatedList = numbersByFrequency[num];

                a.Add(generatedList.Numbers[generatedList.Position / num]);
                generatedList.Position++;
            }

            return a;

        }
    }

    public class GeneratedList
    {
        public int Position { get; set; }
        public int[] Numbers { get; set; }

        public GeneratedList(int pos, int[] nums)
        {
            Position = pos;
            Numbers = nums;
        }
    }
}
