using System.Text;

namespace Leetcode.CodeForces.CP31._1000
{
    class _1849B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);
            Dictionary<int,List<int>> moddict = new Dictionary<int, List<int>>();

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n,k) = (arr[0],arr[1]);

                var amod = Console.ReadLine()!.Split(' ').Select(int.Parse).Select(ai => ai%k).ToArray();

                for(int j=0; j<n; j++)
                {
                    if (!moddict.ContainsKey(amod[j]))
                    {
						moddict[amod[j]] = new List<int>();
					}
                    moddict[amod[j]].Add(j + 1);
                }

                StringBuilder ans = new StringBuilder();

                if(moddict.TryGetValue(0,out var modpositions))
                {
                    foreach(var pos in modpositions)
                    {
                        ans.Append(pos + " ");
                    }
                }

                foreach(var (j,positions) in moddict.OrderByDescending(kv => kv.Key))
                {
					if (j!=0)
					{
						foreach (var pos in positions)
						{
							ans.Append(pos + " ");
						}
					}
				}

                Console.WriteLine(ans.ToString());

                moddict.Clear();
			}
        }
    }
}
