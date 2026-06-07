namespace Leetcode.CodeForces.CP31._1300
{
    internal class _1881D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);
            var primes = GetPrimes(1_000_000);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                var amax =a.Max();

                if(amax==1)
                {
                    Console.WriteLine("YES");
                    continue;
                }

                var factors = Factorize(a,primes);

                var ans = factors.All(kv => kv.Value % n == 0) ? "YES" : "NO";

                Console.WriteLine(ans);
                
            }
        }

        private static Dictionary<int,int> Factorize(int[] a, List<int> primes)
        {
            var result = new Dictionary<int, int>();

            for(int i=0; i< a.Length;++i)
            {
                var ai = a[i];
                var curpointer = 0;

                while (ai > 1)
                {
                    if (ai % primes[curpointer] == 0)
                    {
                        ai /= primes[curpointer];
                        if (result.ContainsKey(primes[curpointer])) result[primes[curpointer]]++;
                        else result[primes[curpointer]] = 1;
                    }
                    else
                    {
                        curpointer++;
                    }
                }
            }
            return result;
        }

        private static List<int> GetPrimes(long amax)
        {
            var step = 2;
            var sieve = new bool[amax - 1];

            for (int i = 0;i <amax-1;i++)
            {
                if(sieve[i] == default)
                {
                   for (int j = i+step; j <amax-1;j+=step)
                   {
                        if(sieve[j] == default)
                        {
                            sieve[j] = !sieve[j];
                        }
                   }
                }
                step++;
            }

            var ans = new List<int>();

            for(int i = 0;i <amax-1;i++)
            {
                if(sieve[i] == default)
                {
                    ans.Add(i + 2);
                }
            }

            return ans;
        }
    }
}