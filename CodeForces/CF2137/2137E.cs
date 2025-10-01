using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF2137
{

    public class _2137E
    {
        public static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {

                var input = Console.ReadLine().Split(' ');
                var n = long.Parse(input[0]);
                var k = int.Parse(input[1]);

                var a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                Dictionary<long, long> frequency = GetFrequencyDict(a);

                Console.WriteLine(AfterMexSum(frequency, n, k));

            }

        }

        private static long AfterMexSum(Dictionary<long, long> frequency, long n, int k)
        {
            long sum = 0;
            long totalcount = 0;

            if (k == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    if (!frequency.ContainsKey(i))
                    {
                        sum += (n - totalcount) * i;
                        return sum;
                    }
                    else if (frequency[i] == 1)
                    {
                        totalcount += 1;
                        sum += i;
                    }
                }
                return sum;
            }

            if (k % 2 == 0)
            {
                for (long i = 0; i < n; i++)
                {
                    if (!frequency.ContainsKey(i))
                    {
                        if (totalcount < n - 1)
                        {
                            sum += (n - totalcount) * (i + 1);
                            return sum;
                        }
                        else
                        {
                            sum += (n - totalcount) * i;
                            return sum;
                        }
                    }
                    else if (frequency[i] > 1)
                    {
                        sum += (n - totalcount) * i;
                        return sum;
                    }
                    else
                    {
                        totalcount += 1;
                        sum += i;
                    }
                }
                return sum;
            }

            if (k % 2 == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    if (!frequency.ContainsKey(i))
                    {
                        sum += (n - totalcount) * i;
                        return sum;
                    }
                    else if (frequency[i] > 1)
                    {
                        sum += (n - totalcount) * (i + 1);
                        return sum;
                    }
                    else
                    {
                        totalcount += 1;
                        sum += i;
                    }
                }
                return sum;
            }

            return 0;
        }

        private static Dictionary<long, long> GetFrequencyDict(int[] a)
        {
            Dictionary<long, long> result = new Dictionary<long, long>();

            foreach (int i in a)
            {
                if (result.ContainsKey(i)) result[i] += 1;
                else result[i] = 1;
            }

            return result;
        }
    }
}
