using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF1703
{
    internal class _1703D
    {
        private static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine());

                string[] s = new string[n];

                for (int j = 0; j < n; j++) s[j] = Console.ReadLine();

                var dict = s.ToHashSet();

                Console.WriteLine(string.Join("",s.Select(str =>
                CanBeMade(str, dict) ? "1" : "0")));

            }
        }

        private static bool CanBeMade(string s, HashSet<string> dict)
        {
            return Enumerable.Range(0, s.Length-1).
                Select(i => (new string(s.Take(i+1).ToArray()), 
                new string(s.Skip(i+1).ToArray()))).
                Any(pair => dict.Contains(pair.Item1) 
                && dict.Contains(pair.Item2));
        }

    }
}
