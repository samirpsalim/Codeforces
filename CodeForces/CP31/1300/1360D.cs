namespace Leetcode.CodeForces.CP31._1300
{
    internal class _1360D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, k) = (arr[0], arr[1]);

                Console.WriteLine(Answer(n,k));
            }
        }

        private static int Answer(long n, long k)
        {
            if (k >= n) return 1;

            if (k * k <= n)
            {
                for(int i = (int)k;i >0;i--)
                {
                    if(n%i == 0) return (int)(n/i);
                }
            }

            for(int i = (int)(n/k) + (n % k == 0 ? 0 : 1); i *i <=n;i++)
            {
                if (n % i == 0) return i;
            }

            for(int i = (int)(n / k); i > 0; i--)
            {
                if (n % i == 0) return (int)(n/i);
            }

            return (int)n;
        }
    }
}
