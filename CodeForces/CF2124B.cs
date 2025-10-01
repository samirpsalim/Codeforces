using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces
{
    internal class CF2124B
    {
        private int MinimumPrefixSum(int[] a)
        {
            int ans = FindMinSum(a);

            int[] b;

            int n = a.Length;

            for (int j = 0; j < n - 1; ++j)
            {
                if (a[j] == 0) break;
                for (int k = j + 1; k < n; ++k)
                {
                    if (a[k] == 0) break;

                    b = (int[])a.Clone();
                    b[j] = b[j] + b[k];
                    b[k] = 0;

                    int temp = FindMinSum(b);
                    if (temp < ans)
                    {
                        ans = temp;
                    }
                }
            }

            return ans;
        }

        int FindMinSum(int[] array)
        {
            int min = array[0];
            int sum = 0;
            foreach (int elem in array)
            {
                if (elem < min) min = elem;
                if (min == 0) break;
                sum += min;
            }
            return sum;
        }
    }
}