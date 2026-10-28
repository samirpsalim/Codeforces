namespace Leetcode.CodeForces.CP31._1500
{
    internal class _1201B
    {
        static void Solve(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

            var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var asum = a.Aggregate(0L,(agg,ai)=>agg+ai);
            var amax=a.Max();

            Console.WriteLine(asum % 2 == 0 && amax * 2 <= asum ? "YES" : "NO");
        }
    }
}
