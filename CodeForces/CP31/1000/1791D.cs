namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1791D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);
            HashSet<char> prefchars = new();
            HashSet<char> suffchars = new();

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var s = Console.ReadLine();
                var prefuniques = new int[n];
                var suffuniques = new int[n];

                for (int j = 0; j < n; j++)
                {
                    prefchars.Add(s![j]);
                    prefuniques[j]= prefchars.Count;
                    suffchars.Add(s![n - 1 - j]);
                    suffuniques[n-1-j]= suffchars.Count;
                }

                var ans = prefuniques[n - 1] + 0;

                for (int j = 0;j < n-1; j++)
                {
                    ans = Math.Max(ans, prefuniques[j] + suffuniques[j+1]);
                }

                Console.WriteLine(ans);

                prefchars.Clear();
                suffchars.Clear();
            }
        }
    }
}
