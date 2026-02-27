namespace Leetcode.CodeForces.CF2200
{
    internal class _2200A
    {
        static void Solve(string[] args)
        {
            int t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++) {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                var max = a.Max();
                Console.WriteLine(a.Count(a => a==max));
            }
        }
    }
}
