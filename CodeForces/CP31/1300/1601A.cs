namespace Leetcode.CodeForces.CP31._1300
{
    internal class _1601A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                var setbits = new int[30];
                var totsetbits = 0;

                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < 30; k++)
                    {
                        if ((a[j] & (1 << k)) != 0)
                        {
                            setbits[k]++;
                            totsetbits++;
                        }
                    }
                }

                var gcd = setbits.Max();

                foreach(var biti in setbits)
                {
                    if (biti != 0) gcd = Gcd(gcd, biti);
                }

                var ans = new List<int>();

                if(gcd == 0)
                {
                    for(int j = 1; j <= n; j++)
                    {
                        ans.Add(j);
                    }
                }
                else
                {
                    for(int j = 1;j <= gcd; j++)
                    {
                        if(gcd%j==0) ans.Add(j);
                    }
                }

                Console.WriteLine(string.Join(' ',ans));
            }
        }

        private static int Gcd(int a, int b)
        {
            if(b>a) return Gcd(b, a);

            if (a % b == 0) return b;

            return Gcd(b, a % b);
        }
    }
}
