using System.Text;

namespace Leetcode.CodeForces.CF2218
{
    internal class _2218C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                StringBuilder s = new StringBuilder();
                for (int j = 0; j < n; j++)
                {
                    s.Append(j + 1);
                    s.Append(" ");
                    s.Append(n + 1 + 2 * j);
                    s.Append(" ");
                    s.Append(n + 2 + 2 * j);
                    s.Append(" ");
                }
                Console.WriteLine(s.ToString());
            }
        }
    }
}
