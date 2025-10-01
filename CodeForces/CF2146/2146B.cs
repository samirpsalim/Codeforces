using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF2146
{
    internal class _2146B
    {
        private static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToImmutableArray();

                var n = input[0];
                var m = input[1];

                var s = new List<List<int>> ();
                var elemtracker = new Dictionary<(int, int), bool> ();

                var selections = Enumerable.Range(0, n)
                    .Aggregate(
                        new List<List<int>> { new List<int>() },
                        (acc, x) => acc.Concat(acc.Select(subset => subset.Concat(new[] { x }).ToList())).ToList()
                    );

                for (int j = 0; j < n; j++)
                {
                    s.Add(Console.ReadLine().Split(' ').Select(int.Parse).Skip(1).ToList());
                }

                for (int j = 0;j < n; j++)
                {
                    foreach (var x in s[j])
                    {
                        if (x <= m) elemtracker[(j, x)] = true;
                    }
                }

                var possibleselectioncount = 0;

                foreach(var selection in selections)
                {
                    var possibleselection = true;

                    for (int j = 1; j <=m; j++) 
                    {
                        if (!selection.Select(s => elemtracker.ContainsKey((s, j))).Any(x => x)) 
                            possibleselection = false;
                    }
                    
                    if(possibleselection) 
                        possibleselectioncount++;

                    if (possibleselectioncount == 3) break;

                }

                Console.WriteLine(possibleselectioncount == 3 ? "YES" : "NO");

            }
        }
    }
}
