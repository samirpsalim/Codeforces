namespace Leetcode.CodeForces.CP31._800
{
    internal class _1866A
    {
        static void Solve(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

            var ans = Console.ReadLine()!.Split(' ').Select(x=>Math.Abs(int.Parse(x))).Min();
            Console.WriteLine(ans);
        }
    }
}
