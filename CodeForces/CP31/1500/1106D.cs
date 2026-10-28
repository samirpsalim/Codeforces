namespace Leetcode.CodeForces.CP31._1500
{
    internal class _1106D
    {
        static void Solve(string[] args)
        {
            var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var (n,m) = (arr[0],arr[1]);

            var seenSet = new HashSet<int>();

            var optionSet = new SortedSet<int>();
            optionSet.Add(1);

            var adjacency = new Dictionary<int, List<int>>();

            var ans = new List<int>();

            for (int i = 0; i < m; i++)
            {
                arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                var (u, v) = (arr[0], arr[1]);

                if(!adjacency.ContainsKey(u)) adjacency.Add(u, new List<int>());
                if(!adjacency.ContainsKey(v)) adjacency.Add(v, new List<int>());

                adjacency[u].Add(v);
                adjacency[v].Add(u);
            }

            while(optionSet.Count > 0)
            {
                var cur = optionSet.First();
                optionSet.Remove(cur);
                foreach(int v in adjacency[cur])
                {
                    if(seenSet.Contains(v)) continue;
                    optionSet.Add(v);
                }
                seenSet.Add(cur);
                ans.Add(cur);
            }

            Console.WriteLine(string.Join(' ',ans));
        }
    }
}
