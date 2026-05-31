namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1527B2
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                string s = Console.ReadLine()!;

                var palindromebreakers = 0;
                var zerocount = 0;

                for (int j = 0; 2*j < n; j++)
                {
                    if (s[j] != s[n - 1 - j])
                    {
                        palindromebreakers++;
                    }
                    else if (s[j] == '0')
                    {
                        zerocount += j == n - 1 - j ? 1 : 2;
                    }
                }

                if(palindromebreakers >= 2)
                {
                    Console.WriteLine("ALICE");
                }
                else if(palindromebreakers == 0)
                {
                    var ans = zerocount == 1 ? "BOB" : (zerocount % 2) switch
                    {
                        0 => "BOB",
                        1 => "ALICE"
                    };
                    Console.WriteLine(ans);
                }
                else
                {
                    Console.WriteLine(zerocount == 1 ? "DRAW" : "ALICE");
                }
            }
        }
    }
}
