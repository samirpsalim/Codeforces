namespace Leetcode.CodeForces.CP31._1400
{
    internal class NodeEntry
    {
        public NodeEntry(int parent, bool isSafe)
        {
            Parent = parent;
            IsSafe = isSafe;
        }

        public int Parent {  get; set; }
        public bool IsSafe { get; set; }
    }

    internal class _1143C
    {
        static void Solve(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

            var nodedict = new Dictionary<int, NodeEntry>();

            var deletedNodes = new List<int>();

            for (int i = 1; i <= n; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                var pi = arr[0];
                var ci= arr[1]==0;

                if(nodedict.ContainsKey(i))
                {
                    nodedict[i].Parent = pi;
                }
                else
                {
                    var node = new NodeEntry(pi, ci || (pi == -1));
                    nodedict[i] = node;
                }

                if (ci && pi != -1)
                {
                    if(nodedict.ContainsKey(pi)) nodedict[pi].IsSafe = true;
                    else nodedict[pi] = new NodeEntry(-1, ci);
                }
            }

            foreach (var node in nodedict)
            {
                var nodeval = node.Value;

                if(!nodeval.IsSafe) deletedNodes.Add(node.Key);
            }

            Console.WriteLine(deletedNodes.Count==0? -1: string.Join(' ', deletedNodes));
        }
    }
}
