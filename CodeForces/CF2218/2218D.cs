
namespace Leetcode.CodeForces.CF2218
{
    internal class _2218D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);
            var primes = GetTenThousandPrimes();

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var result = new long[n];
                result[0] = 2;
                for (int j = 1; j < n; j++)
                {
                    result[j] = (long)primes[j]*(long)primes[j-1];
                }
                Console.WriteLine(string.Join(" ", result));
            }
        }

        private static int[] GetTenThousandPrimes()
        {
            var last = 104729;
            var sieve = new bool[last-1];
            Array.Fill(sieve, true);

            for (int i = 0; i<last-1;++i)
            {
                if (!sieve[i]) continue;

                var start = i;
                var step = i + 2;
                for (int j = start+step; j < last-1; j+=step)
                {
                    sieve[j] = false;
                }
            }

            var result = new int[10000];
            var pos = 0;
            for (int i = 0;i<last-1;++i)
            {
                if(sieve[i])
                {
                    result[pos] = i+2;
                    pos++;
                }
            }
            return result;
        }
    }
}
