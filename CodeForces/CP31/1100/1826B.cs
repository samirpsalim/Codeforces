namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1826B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var nopairdetected = true;
                var ans = 0;

                for(int j =0; j<(n/2);++j)
                {
                    if (a[j] != a[n-1-j])
                    {
                        if (nopairdetected)
                        {
                            ans = Math.Abs(a[j] - a[n - 1 - j]);
                            nopairdetected = false;
                        }
                        else
                        {
                            ans = Gcd(ans, Math.Abs(a[j] - a[n - 1 - j]));
                        }
                    }
                }

                Console.WriteLine(ans);
            }
        }

        private static int Gcd(int a, int b)
        {
            if (a < b)
            {
                return Gcd(b, a);
            }

            if (a % b == 0)
                return b;

            return Gcd(b,a % b);
        }
    }
}
