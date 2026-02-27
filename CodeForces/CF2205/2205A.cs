namespace Leetcode.CodeForces.CF2205
{
    internal class _2205A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for(int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var p = Console.ReadLine()!.Split(' ').Select(int.Parse).ToList();

                var index = p.IndexOf(n);

                var temp = p[index];
                p[index] = p[0];
                p[0] = temp;

                Console.WriteLine(string.Join(" ", p));
            }
        }
    }
}
