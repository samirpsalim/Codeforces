namespace Leetcode.CodeForces.CP31._1600
{
    internal class _1795D
    {
        private static long div = 998244353;

        static void Solve(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

            var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var ans = 1L;

            for (int i = 1; i <= n / 6; i++)
            {
                ans = (ans * (((n / 6 + i) * Inv(i)) % div)) % div;
            }


            for (int i = 0; i < n; i+=3)
            {
                ans = (ans * GetMultiplier(a.AsSpan(i,3)))%div; 
            }

            Console.WriteLine(ans);
        }

        private static int GetMultiplier(Span<int> span)
        {
            span.Sort();

            if (span[0] != span[1]) return 1;
            
            if(span[1] != span[2]) return 2;

            return 3;
        }

        private static long BinPow(long x, long y)
        {
            var z = 1L;
            while (y>0)
            {
                if (y % 2 == 1) z = (z*x)%div;
                x = (x * x)%div;
                y /= 2;
            }
            return z;
        }

        private static long Inv(long x)
        {
            return BinPow(x, div - 2);
        }
    }
}
