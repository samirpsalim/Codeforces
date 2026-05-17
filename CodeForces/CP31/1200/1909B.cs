namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1909B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(long.Parse)
                        .Order().ToArray();

                var gcd = a[1] - a[0];

                for (int j = 2; j < n; j++)
                {
                    gcd = Gcd(gcd, a[j] - a[j - 1]);
                }

                Console.WriteLine(2*gcd);
            }
        }

        private static long Gcd(long a, long b)
        {
            if(b>a) return Gcd(b,a);

            if (a % b == 0) return b;

            return Gcd(b,a%b);
        }
    }
}
