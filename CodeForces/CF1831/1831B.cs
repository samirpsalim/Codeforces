using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF1831
{
    internal class _1831B
    {
        private static void Solve(string[] args)
        {
            int t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                var b = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                Console.WriteLine(LargestEqualSubarray(n, a, b));
            }
        }

        private static int LargestEqualSubarray(int n, int[] a, int[] b)
        {
            int largestLength = 1;
            Dictionary<int, int> contiguouscountinA = new();

            int start = 0;
            contiguouscountinA.Add(a[0], 1);

            for (int i = 1; i < n; i++)
            {
                if (a[start]!= a[i])
                {
                    UpdateContiguousCountDict(contiguouscountinA, a, start, i);
                    if (contiguouscountinA[a[start]]>largestLength)
                    {
                        largestLength = contiguouscountinA[a[start]];
                    }

                    start = i;
                }
            }

            UpdateContiguousCountDict(contiguouscountinA, a, start, n);

            if (contiguouscountinA[a[start]] > largestLength)
            {
                largestLength = contiguouscountinA[a[start]];
            }

            start = 0;
            Dictionary<int, int> contiguouscountinB = new();
            contiguouscountinB.Add(b[0], 1);
            largestLength = CombinedLength(contiguouscountinA, contiguouscountinB,
                b[0], largestLength);

            for (int i = 1; i < n; i++)
            {
                if (b[start] != b[i])
                {
                    UpdateContiguousCountDict(contiguouscountinB, b, start, i);
                    largestLength =CombinedLength(contiguouscountinA, contiguouscountinB, b[start], largestLength);

                    start = i;
                }
            }

            UpdateContiguousCountDict(contiguouscountinB, b, start, n);
            largestLength = CombinedLength(contiguouscountinA, contiguouscountinB,
                                b[start], largestLength);

            return largestLength;


        }

        private static int CombinedLength(Dictionary<int, int> contiguouscountinA, Dictionary<int, int> contiguouscountinB, int v, int largestLength)
        {
            if(contiguouscountinA.ContainsKey(v))
            {
                return Math.Max(contiguouscountinA[v] + contiguouscountinB[v], largestLength);
            }
            return Math.Max(contiguouscountinB[v], largestLength);
        }

        private static void UpdateContiguousCountDict(Dictionary<int, int> contiguouscountdict, int[] array, int start, int i)
        {
            if (!contiguouscountdict.ContainsKey(array[start]))
            {
                contiguouscountdict[array[start]] = i - start;
            }
            else if (contiguouscountdict[array[start]] < i - start)
            {
                contiguouscountdict[array[start]] = i - start;
            }
        }
    }
}
