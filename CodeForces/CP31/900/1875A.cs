namespace Leetcode.CodeForces.CP31._900
{
    internal class _1875A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (a, b) = (arr[0], arr[1]);

                Console.WriteLine(Console.ReadLine()!.Split(' ').Select(int.Parse).
                Aggregate((long)b,(acc,xi) => xi>=a? acc+(long)a-1: acc+ (long)xi));

            }
        }
    }
}
