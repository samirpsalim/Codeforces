namespace Leetcode.CodeForces.CF2227
{
    internal class _2227B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var openparcount = Console.ReadLine()!.Count(c => c == '(');

                Console.WriteLine(n==2*openparcount ? "YES" : "NO");
            }
        }
    }
}
