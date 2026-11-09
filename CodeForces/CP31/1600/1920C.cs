namespace Leetcode.CodeForces.CP31._1600
{
    internal class _1920C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a= Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var ans = 1;

                var impossibles = new HashSet<int>();

                for (int j = 2; j <=n; j++)
                {
                    if(n%j!=0) continue;
                    if(impossibles.Contains(j)) continue;

                    var gcd = Math.Abs(a[0]-a[n/j]);

                    for(int k=0; k+n/j<n;++k)
                    {
                        if(a[k] == a[n / j +k]) continue;

                        var curgcd = Math.Abs(a[k] - a[n / j+k]);

                        if(gcd == 0) gcd=curgcd;
                        else gcd = Gcd(gcd, curgcd);

                        if (gcd == 1) break;
                    }

                    if (gcd == 0 || gcd > 1) ans++;

                }

                Console.WriteLine(ans);
            }
        }

        private static int Gcd(int a, int b)
        {
            if(a<b) return Gcd(b,a);

            if (a % b == 0) return b;

            return Gcd(b,a%b);
        }
    }
}
