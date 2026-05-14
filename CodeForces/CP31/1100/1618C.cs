
namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1618C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for(int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                long[] gcds = [a[0],a[1]];

                for(int j=2; j<n; j++)
                {
                    gcds[j%2] = Gcd(a[j], gcds[j%2]);
                }

                if (gcds[0] == gcds[1])
                {
                    Console.WriteLine(0);
                    continue;
                }

                var (chosengcd,iter) = gcds[0] > gcds[1] ? (gcds[0],1) : (gcds[1],0);
                
                var flag = false;

                for(int j= iter; j<n; j+=2)
                {
                    if (a[j]%chosengcd ==0)
                    {
                        flag = true;
                        break;
                    }
                }

                if(flag)
                {
                    flag = false;
                    chosengcd = gcds[iter];
                    iter = 1 - iter;

                    for (int j = iter; j < n; j += 2)
                    {
                        if (a[j] % chosengcd == 0)
                        {
                            flag = true;
                            break;
                        }
                    }
                }

                Console.WriteLine(flag?0:chosengcd);
            }
        }

        private static long Gcd(long a, long b)
        {
            if (b > a) return Gcd(b, a);

            if (a % b == 0) return b;

            return Gcd(b, a % b);
        }
    }
}
