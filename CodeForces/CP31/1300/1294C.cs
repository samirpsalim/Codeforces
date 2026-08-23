namespace Leetcode.CodeForces.CP31._1300
{
    internal class _1294C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            var primes = GetPrimes();

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var hasAns = TryGetAnswer(n, primes, out var ans);

                if (hasAns)
                {
                    Console.WriteLine("YES");
                    Console.WriteLine(string.Join(" ", ans));
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }

        private static int[] GetPrimes()
        {
            bool[] seen = new bool[99_999];

            var start = -1;
            var step = 1;

            while (start+1<seen.Length)
            {
                start++;
                step++;

                if (seen[start])
                {
                    continue;
                }

                for(int j= start+step; j<seen.Length; j+=step)
                {
                    seen[j] = true;
                }
            }

            return seen.Select((x,id) => (x,id+2)).Where(a=> !a.x)
                .Select(a=>a.Item2).ToArray();
        }

        private static bool TryGetAnswer(int n, int[] primes, out int[]? ans)
        {
            var cur = 0;

            var curprime = 0;
            ans = new int[3];

            while(curprime < primes.Length)
            {
                if (n % primes[curprime] == 0)
                {
                    cur++;
                    ans[0] = primes[curprime];
                    n/= primes[curprime];
                    break;
                }
                else
                {
                    curprime++;
                }
            }

            if (cur == 0)
            {
                return false;
            }

            while (curprime < primes.Length)
            {
                if (n % primes[curprime] == 0)
                {
                    if (ans[1]==0)
                    {
                        ans[1] = primes[curprime];
                    }
                    else
                    {
                        ans[1] *= primes[curprime];
                    }

                    n /= primes[curprime];

                    if (ans[0] != ans[1])
                    {
                        cur++;
                        break;
                    }
                }
                else
                {
                    curprime++;
                }
            }

            if(cur ==1)
            {
                return false;
            }

            if (n == ans[0] || n == ans[1] || n==1) return false;

            ans[2] = n;
            return true;
        }
    }
}
