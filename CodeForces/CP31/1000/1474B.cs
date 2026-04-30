
namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1474B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var d = int.Parse(Console.ReadLine()!);

                var p = FindNextPrime(d + 1);

                var q = FindNextPrime(p+d);

                Console.WriteLine(Math.Min((long)p*p*p,(long)p*q));
            }
        }

        private static int FindNextPrime(int n)
        {
            if (n == 2 || n == 3)
            {
                return n;
            }

            while(true)
            {    
                var flag = true;
                for (int i = 2; i * i <= n; i++)
                {
                    if (n % i == 0)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag) return n;
                n++;
            }
        }
    }
}
