namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1438B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var bcount = Console.ReadLine()!.Split(' ').Distinct().Count();

                Console.WriteLine(bcount!=n ? "YES" : "NO");
            }
        }
    }
}
