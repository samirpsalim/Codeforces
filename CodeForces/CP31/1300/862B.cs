namespace Leetcode.CodeForces.CP31._1300
{
    internal class _862B
    {
        static void Solve(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

           var edgedict = new Dictionary<int, List<int>>();

            for (int i = 1; i < n; i++)
            {
                var ai = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
                if (edgedict.ContainsKey(ai[0]))
                {
                    edgedict[ai[0]].Add(ai[1]);
                }
                else
                {
                    edgedict[ai[0]]= [ai[1]];
                }
                if (edgedict.ContainsKey(ai[1]))
                {
                    edgedict[ai[1]].Add(ai[0]);
                }
                else
                {
                    edgedict[ai[1]] = [ai[0]];
                }
            }

            HashSet<int> set1=new(), set2 = new(), seen = new();

            Queue<int> nodequeue = new Queue<int>();

            set1.Add(1);
            seen.Add(1);
            nodequeue.Enqueue(1);

            while (nodequeue.Count > 0)
            {
                var node = nodequeue.Dequeue();

                var curset = set1.Contains(node)? set2: set1;

                foreach (var item in edgedict[node])
                {
                    curset.Add(item);

                    if(seen.Contains(item)) continue;

                    seen.Add(item);                    
                    nodequeue.Enqueue(item);
                }
            }

            Console.WriteLine(set2.LongCount()*set1.LongCount()+1-n);
        }
    }
}
