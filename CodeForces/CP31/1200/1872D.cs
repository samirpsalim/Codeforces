namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1872D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            
                var (n,x,y) = (arr[0], arr[1], arr[2]);

                var posnums = n / x;
                var negnums = n / y;
                var lcm = Lcm(x, y);
                var comnums =(int) (n / lcm);
                posnums -= comnums;
                negnums -= comnums;

                var possum = posnums*(2*(long)n+1-posnums)/2;
                var negsum = (negnums + 1) * (long)negnums / 2;

                Console.WriteLine(possum - negsum);
            }
        }

        private static long Lcm(long x, long y)
        {
            return (x*y)/ Gcd(x, y);
        }

        private static long Gcd(long x, long y)
        {
            if(y>x) return Gcd(y,x);

            if (x % y == 0) return y;

            return Gcd(y, x % y);
        }
    }
}
