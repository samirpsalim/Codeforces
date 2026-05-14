namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1731B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var ans = (4 * (Int128)n - 1) * n * (n + 1) * 337;
                Console.WriteLine(ans%1_000_000_007);
            }
        }
    }
}
