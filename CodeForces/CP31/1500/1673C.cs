namespace Leetcode.CodeForces.CP31._1500
{
    internal class _1673C
    {
        static void Solve(string[] args)
        {
            var palindromes = GetRelevantPalindromes();

            var dp = new int[40001];
            dp[0] = 1;

            for (int j = 0; j < palindromes.Length; j++)
            {
                for (int k = 1; k < 40001; k++)
                {
                    if (k - palindromes[j] >= 0)
                    {
                        dp[k] = (dp[k] + dp[k - palindromes[j]])% 1_000_000_007;
                    }
                }
            }

            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = ushort.Parse(Console.ReadLine()!);

                Console.WriteLine(dp[n]);
            }
        }

        #region palindromecalc

        private static ushort[] GetRelevantPalindromes()
        {
            var n = 1;
            var ans = new List<ushort>(500);
            var diff = 1;

            while(n<40000)
            {
                ans.Add((ushort)n);

                diff = n switch
                {
                    int xn when All9(xn) =>2,
                    int xn when Diff10(xn) => 10,
                    int xn when Diff11(xn) => 11,
                    int xn when Diff100(xn) => 100,
                    int xn when Diff110(xn) => 110,
                    _ => diff
                };

                n += diff;
            }

            return ans.ToArray();
        }

        private static bool Diff110(int n)
        {
            if (n <= 1000) return false;

            if (n <= 10000) return (n / 10) % 100 == 0;

            return (n / 100) % 10 == 9;
        }

        private static bool Diff100(int n)
        {
            if(n<=10000) return false;

            return (n / 100) % 10 == 0;
        }

        private static bool Diff11(int n)
        {
            if (n < 100) return n == 11;

            if (n < 999) return (n / 10) % 10 == 9;

            if (n < 9999) return (n / 10) % 100 == 99;

            return (n / 10) % 1000 ==999;
        }

        private static bool Diff10(int n)
        {
            if (n > 100 && n < 1000)
                return (n / 10)%10 ==0;
            else return false;
        }

        private static bool All9(int n)
        {
            n = n + 1;

            while (n>=10)
            {
                if (n % 10 == 0) n /= 10;
                else return false;
            }

            return n==1;
        }

        #endregion
    }
}
