namespace Leetcode.CodeForces.CF2222
{
    internal class _2222A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var ans = Console.ReadLine()!.Split(' ').Select(int.Parse).Any(ai => ai==100);

                Console.WriteLine(ans? "YES" : "NO");
            }
        }
    }
}
