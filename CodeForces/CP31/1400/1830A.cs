namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1830A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var adj = new List<List<int>>(n);
                var dp = new int[n];

                var idxmap = new Dictionary<(int u,int v),int>(n-1);

                for(int j=0; j<n; j++)
                {
                    adj.Add(new List<int>());
                }

                for (int j = 0; j < n - 1; j++)
                {
                    var curedge = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                    var (u, v) = (curedge[0]-1, curedge[1]-1);

                    adj[u].Add(v);
                    adj[v].Add(u);

                    idxmap[(u, v)] = j;
                    idxmap[(v, u)] = j;
                }

                idxmap[(-1, 0)] = -1;

                dp[0] = 1;

                Dfs(adj, idxmap, 0, -1, dp);

                Console.WriteLine(dp.Max());
            }
        }

        private static void Dfs(List<List<int>> adj, Dictionary<(int u, int v), int> idxmap, int vert, int par, int[] dp)
        {
            foreach(var vi in adj[vert])
            {
                if(vi==par) continue;

                if (idxmap[(par, vert)] < idxmap[( vert, vi)]) 
                {
                    dp[vi] = dp[vert];
                } 
                else
                {
                    dp[vi] = dp[vert] + 1;
                }
                Dfs(adj,idxmap, vi, vert,dp);
            }
        }
    }
}
