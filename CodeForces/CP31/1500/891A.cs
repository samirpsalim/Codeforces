namespace Leetcode.CodeForces.CP31._1500
{
    internal class _891A
    {
        static void Solve(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

            var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var count1 = a.Count(ai => ai==1);

            if(count1>0)
            {
                Console.WriteLine(n-count1);
                return;
            }

            var dp = new int[2][];
            dp[0] = new int[n];
            dp[1] = new int[n-1];

            for(int i = 0; i < n; i++)
            {
                dp[0][i] = a[i];
            }

            var seen = false;
            var curcount = 0;

            while(curcount<n-1)
            {
                for(int i = 0;i+ curcount < n-1;i++)
                {
                    var gcd= Gcd(dp[curcount % 2][i], a[i + curcount + 1]);
                    dp[(curcount + 1) % 2][i]= gcd;
                    if (dp[(curcount + 1) % 2][i]==1)
                    {
                        seen = true;
                        break;
                    }
                }

                if(seen)
                {
                    break;
                }
                curcount++;
            }

            Console.WriteLine(seen? curcount+n:-1);
        }

        private static int Gcd(int v1, int v2)
        {
            if (v1 < v2) return Gcd(v2, v1);

            if (v1 % v2 == 0) return v2;

            return Gcd(v2, v1 % v2);
        }
    }
}
