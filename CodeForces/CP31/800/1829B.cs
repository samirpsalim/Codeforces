namespace Leetcode.CodeForces.CP31._800
{
    internal class _1829B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var ans = Console.ReadLine()!.Split('1').Max(x=>x.AsSpan().Count('0'));
                Console.WriteLine(ans);
            }
        }
    }
}
