namespace Leetcode.CodeForces.CP31._1300
{
    internal class _1879C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                string s = Console.ReadLine()!;

                var len = 1;
                var ans = 1L;
                var switches = 1;

                for (int j = 1; j < s.Length; j++)
                {
                    if (s[j] != s[j-1])
                    {
                        ans = (ans*len)% 998244353;
                        len = 1;
                        switches++;
                    }
                    else
                    {
                        len++;
                    }
                }

                ans = (ans * len) % 998244353;
                var k = s.Length - switches;

                for (int j = 1; j <= k; j++)
                {
                    ans = (ans * j) % 998244353;
                }

                Console.WriteLine($"{k} {ans}");
            }
        }
    }
}
