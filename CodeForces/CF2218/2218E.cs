namespace Leetcode.CodeForces.CF2218
{
    internal class _2218E
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                var ans = a[0] ^ a[1];

                for (int j = 0; j < n-1; j++)
                {
                    for (int k = j+1; k<n; k++)
                    {
                        ans = Math.Max(ans, a[k] ^ a[j]);
                    }
                }
                Console.WriteLine(ans);

            }
        }
    }
}
