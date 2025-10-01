using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF1703
{
    internal class _1703G
    {
        private static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < t; i++)
            {
                var input = Console.ReadLine().Split(' ').
                    ToArray();
                var n = long.Parse(input[0]);
                long k = long.Parse(input[1]);

                var a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                Process(n, k, a);
            }

        }

        private static void Process(long n, long k, int[] a)
        {
            long baseSum = a[n-1];
            long[] suffixSum = new long[n];
            suffixSum[n-1] = a[n-1];

            for (long i = n-2; i >= 0; i--)
            {
                baseSum += a[i];
                suffixSum[i] = suffixSum[i + 1];
                suffixSum[i]+= a[i];
            }

            long maxcoins = baseSum -(n*k);
            long current = 0;

            for(int i =0; i < n; i++)
            {
                current = baseSum - (i * k);
                if(i+31<n) current -= suffixSum[i+31];

                for(int j=i; j<Math.Min(n, i+31); j++)
                {
                    current = (current - a[j]) + (a[j] >> ((j+1)-i));
                }
                if(current > maxcoins) maxcoins = current;

            }

            Console.WriteLine(maxcoins);

        }
    }
}
