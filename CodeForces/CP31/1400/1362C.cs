namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1362C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = long.Parse(Console.ReadLine()!);

                var ans = 0L;

                while(n>0)
                {
                    ans += n;
                    n /= 2;
                }

                Console.WriteLine(ans);
            }
        }
    }
}
