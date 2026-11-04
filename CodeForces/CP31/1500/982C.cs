namespace Leetcode.CodeForces.CP31._1500
{
    internal class _982C
    {
        static void Solve(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

            var adj = new List<int>[n];

            var edges = new (int, int)[n - 1];
            var deg = new int[n];

            for (int i = 0; i < n - 1; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var u = arr[0] - 1;
                var v = arr[1] - 1;

                edges[i] = (u, v);

                if (adj[u] is null) adj[u] = new List<int>();
                if (adj[v] is null) adj[v] = new List<int>();

                adj[u].Add(v);
                adj[v].Add(u);
                deg[u]++;
                deg[v]++;
            }

            if (n % 2 == 1)
            {
                Console.WriteLine(-1);
                return;
            }

            var root = -1;
            for (int i = 0; i < n; ++i)
            {
                if (deg[i] == 1)
                {
                    root = i;
                    break;
                }
            }

            var ans = 0;

            Calculate(adj, root, -1, ref ans);

            Console.WriteLine(ans);
        }

        private static int Calculate(List<int>[] adj, int node, int par, ref int ans)
        {
            var tot = 1;

            foreach (var u in adj[node])
            {
                if (u != par)
                {
                    tot += Calculate(adj, u, node, ref ans);
                }
            }

            if (tot % 2 == 0 && par!=-1) ans++;

            return tot;
        }
    }
}