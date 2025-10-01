using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF2137
{
    internal class _2137F
    {
        private static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine());

            long n;

            for(long i=0; i<t; i++)
            {
                n = int.Parse(Console.ReadLine());

                var a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                var b = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                Console.WriteLine(Result(a, b,n));
            }
        }

        private static long Result(int[] a, int[] b, long n)
        {
            List<long> maxStack = new();

            long ans = 0;

            for(long i = 0; i < n; ++i)
            {
                if(maxStack.Count ==0)
                {
                    if (a[i] == b[i]) ans += (i+1)*(n - i);

                    maxStack.Add(i);
                }
                else
                {
                    while (checkMax(a, a[i],maxStack)) maxStack.RemoveAt(maxStack.Count-1);
                    ans += CalculateFromMaxStack(maxStack, a[i], b[i], i, n, a);
                    maxStack.Add(i);
                }
            }

            return ans;
        }

        private static long CalculateFromMaxStack(List<long> maxStack, int ai, int bi, 
            long i, long n, int[] a)
        {
            if (ai == bi) return (i + 1) * (n - i);

            if (ai > bi && maxStack.Count > 0) 
                return (maxStack.Last() + 1) * (n - i);

            if (ai > bi) return 0;

            if (ai < bi && maxStack.Count > 0)
            {
                if (a[maxStack.First()] < bi)
                {
                    return 0;
                }

                int start = 0;
                int end = maxStack.Count - 1;
                int mid = start + (end - start) / 2;
                int temp;

                while (start < end - 1) 
                {
                    if (a[maxStack[mid]] >= bi) start = mid;
                    else end = mid-1;
                    temp = mid;
                    mid = start + (end - start) / 2;
                }
                if(end == start +1 && a[maxStack[end]] >= bi) mid= end;
                return ((long)maxStack[mid]+1) * (n - i);
            }
            return 0;
        }

        private static bool checkMax(int[] a, int v, List<long> maxStack)
        {
            if (maxStack.Count == 0) return false;
            if (a[maxStack.Last()] < v) return true;
            return false;
        }
    }
}
