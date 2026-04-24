namespace Leetcode.CodeForces.CP31._900
{
    internal class _1559A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var ans = Console.ReadLine()!.Split(' ').Select(int.Parse).
                    Aggregate((acc,ai) => acc&ai);

                Console.WriteLine(ans);
            }
        }
    }
}
