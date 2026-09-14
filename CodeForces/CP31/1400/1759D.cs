namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1759D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n,m) = (arr[0],arr[1]);

                var factor2 = FactorizeCount(n , 2);
                var factor5 = FactorizeCount(n , 5);

                var pow10= Math.Min(factor2, factor5);

                factor2-=pow10;
                factor5-=pow10;

                var ndash = n/ Math.Pow(10,pow10);

                var curfac = factor2 == 0 ? 2 : 5;
                var mfacCount = FactorizeCount(m,curfac);
                var k = 1L;

                for(int j=0; j<factor2+factor5; ++j)
                {
                    if(k*curfac<=m) k*=curfac;
                    else break;
                }

                while(k*10 <=m)
                {
                    k *= 10;
                }

                k = m - m % k;

                Console.WriteLine(n*k);
            }
        }

        private static int FactorizeCount(int n, int f)
        {
            var ans = 0;

            while (n > 0)
            {
                if (n % f == 0) ans++;
                else break;

                n /= f;
            }
            return ans;
        }
    }
}
