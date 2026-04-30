namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1374C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n= int.Parse(Console.ReadLine()!);
                var s = Console.ReadLine()!;

                var ans = 0;

                var openpars = 0;

                for(int j=0; j<n; j++)
                {
                    if (s[j] == '(')
                        openpars++;
                    else if (openpars == 0)
                        ans++;
                    else
                        openpars--;
                }

                Console.WriteLine(ans);
            }
        }
    }
}
