
namespace Leetcode.CodeForces.CP31._1500
{
    internal class _982C
    {
        static void Solve(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

            var adj = new List<int>[n];

            var edges = new (int, int)[n - 1];

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
            }

            if (n % 2 == 1)
            {
                Console.WriteLine(-1);
                return;
            }

            var ans = 0;
            for (int i = 0; i < n - 1; i++)
            {
                var edge = edges[i];

                if (IsValidCut(adj, edge.Item1, edge.Item2)) ans++;
            }

            Console.WriteLine(ans);
        }

        private static bool IsValidCut(List<int>[] adj, int u, int v)
        {
            var stack = new Stack<int>();
            stack.Push(u);

            var seenSet = new HashSet<int>();

            while (stack.Count > 0)
            {
                var top = stack.Pop();
                var ad = adj[top];
                seenSet.Add(top);

                for (int i = 0; i < ad.Count; i++)
                {
                    if (seenSet.Contains(ad[i])) continue;

                    if (top == u && ad[i] == v) continue;
                    if (top == v && ad[i] == u) continue;

                    stack.Push(ad[i]);
                }
            }

            return seenSet.Count % 2 == 0;

        }
    }
}
