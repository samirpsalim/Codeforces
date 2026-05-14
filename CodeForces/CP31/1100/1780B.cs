namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1780B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse)
                        .ToArray();

                var sum = a.Sum(x=>(long)x);

                var ans = 1L;
                var prefsum = 0L;
                
                for(int j=0; j<n-1; j++)
                {
                    prefsum += a[j];
                    ans = Math.Max(ans, Gcd(sum,prefsum));
                }

                Console.WriteLine(ans);
            }
        }

        private static long Gcd(long sum, long prefsum)
        {
            if(prefsum>sum) return Gcd(prefsum, sum);

            if (sum % prefsum == 0) return prefsum;

            return Gcd(prefsum, sum % prefsum);
        }
    }
}
