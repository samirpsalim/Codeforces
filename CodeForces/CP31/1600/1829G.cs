namespace Leetcode.CodeForces.CP31._1600
{
    internal class _1829G
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var currow = GetRow(n);

                long ans = (long)n*n;

                var l = n;
                var r = n;

                for (int j=currow-1; j>0; j--)
                {
                    var start = (j - 1) * j / 2 + 1;
                    var end = (j + 1) * j / 2;

                    l = (l-j-1) < start ? start : (l - j - 1);
                    r= (r-j) > end ? end : (r - j);

                    ans += SquareSum(r) - SquareSum(l - 1);
                }

                Console.WriteLine(ans);
            }
        }

        private static long SquareSum(long n)
        {
            return n * (n + 1) * (2 * n + 1) / 6;
        }

        private static int GetRow(int n)
        {
            var start = 1;
            var end = n;
            var mid=(start+end)/2;

            while(start<end)
            {
                if ((long)mid * (mid + 1) / 2 < n) start = mid + 1;
                else end = mid;
                
                mid= (start+end)/2;
            }

            return mid;
        }
    }
}
