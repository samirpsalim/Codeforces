namespace Leetcode.CodeForces.CP31._1600
{
    internal record struct Node(int pos, int par);

    internal class _1702E
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse((Console.ReadLine()!));

                var a = new (int, int)[n];

                var dict = new Dictionary<int, HashSet<int>>();
                var group = new int[n];
                Array.Fill(group, -1);
                var possible = true;

                for (int j = 0; j < n; j++)
                {
                    var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                    if (!possible) continue;

                    if (!dict.ContainsKey(arr[0])) dict[arr[0]] = new HashSet<int>();
                    if (!dict.ContainsKey(arr[1])) dict[arr[1]] = new HashSet<int>();
                    dict[arr[0]].Add(j);
                    dict[arr[1]].Add(j);

                    if(dict[arr[0]].Count > 2 || dict[arr[1]].Count>2) possible = false;

                    a[j] = new(arr[0], arr[1]);
                }

                if(!possible)
                {
                    Console.WriteLine("NO");
                    continue;
                }

                var seenQueue = new Queue<Node>();
                var seen = new bool[n];
                var seriesStart = 0;

                for (int j = 0; j < n; j++)
                {
                    int cur;
                    if (seenQueue.Count == 0)
                    {
                        cur = group.AsSpan(seriesStart).IndexOf(-1);
                        seriesStart += cur;
                        cur = seriesStart;
                        group[cur] = 0;
                        seen[cur] = true;
                    }
                    else
                    {
                        var deq = seenQueue.Dequeue();
                        cur = deq.pos;
                        group[cur] = 1 - group[deq.par];
                    }

                    var l = a[cur].Item1;
                    var r = a[cur].Item2;

                    var delete = new List<int>();

                    foreach (var di in dict[l])
                    {
                        if (!seen[di])
                        {
                            seenQueue.Enqueue(new Node(di, cur));
                            seen[di] = true;
                        }
                        else
                        {
                            delete.Add(di);
                        }
                    }

                    foreach(var di in delete) dict[l].Remove(di); 

                    delete.Clear();

                    foreach (var di in dict[r])
                    {
                        if (!seen[di])
                        {
                            seenQueue.Enqueue(new Node(di, cur));
                            seen[di] = true;
                        }
                        else
                        {
                            delete.Add(di);
                        }
                    }

                    foreach (var di in delete) dict[r].Remove(di);
                }

                var sets = new HashSet<int>[2];

                for (int j = 0; j < n; ++j)
                {
                    if (sets[group[j]] is null) sets[group[j]] = new HashSet<int>();
                    var cura = a[j];
                    sets[group[j]].Add(cura.Item1);
                    sets[group[j]].Add(cura.Item2);
                }

                Console.WriteLine(((sets[0]?.Count??0) == n) && ((sets[1]?.Count??0) == n) ? "YES" : "NO");
            }
        }
    }
}
