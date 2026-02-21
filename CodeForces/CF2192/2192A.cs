namespace Leetcode.CodeForces.CF2192
{
    internal class _2192A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var s = Console.ReadLine();
                var count = s[0] == s[n - 1] ? 1 : 2;
                for (int j = 0; j < n - 1; j++)
                {
                    if (s[j] != s[j+1]) count++;
                }
                Console.WriteLine(count>n?n:count);

            }
        }
    }
}
