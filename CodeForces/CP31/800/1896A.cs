namespace Leetcode.CodeForces.CP31._800
{
    internal class _1896A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                Console.WriteLine(a[0]==1 ? "YES" : "NO");
            }
        }
    }
}
