namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1519C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var u = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                var s = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var usmap = new Dictionary<int, List<int>>();

                var ans = new long[n];

                for(int j = 0; j < n; j++)
                {
                    if (!usmap.ContainsKey(u[j]))
                    {
                        usmap[u[j]] = new List<int>();
                    }
                    usmap[u[j]].Add(s[j]);
                }

                foreach(var kv in usmap)
                {
                    var skills = kv.Value;
                    skills.Sort();
                    skills.Reverse();

                    var dp = new long[skills.Count];
                    dp[0] = skills[0];

                    for(int j = 1; j < skills.Count; j++)
                    {
                        dp[j] = dp[j - 1] + skills[j];
                    }

                    for(int j = 1;j <= skills.Count; j++)
                    {
                        var last = skills.Count - (skills.Count % j) - 1;
                        ans[j-1] += dp[last];
                    }
                }

                Console.WriteLine(string.Join(' ',ans));
            }
        }
    }
}
