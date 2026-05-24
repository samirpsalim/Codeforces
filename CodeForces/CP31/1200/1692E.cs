namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1692E
    {
		static void Solve(string[] args)
		{
			var t = int.Parse(Console.ReadLine()!);

			for (int i = 0; i < t; i++)
			{
				var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
				var (n, s) = (arr[0], arr[1]);

				var a = Console.ReadLine()!.Split(' ').Select(ai => ai == "1").ToArray();

				var posList = new List<int>(n);

				posList.Add(0);

				for (int j = 0; j < n; j++)
				{
					if (a[j])
					{
						posList.Add(j+1);
					}
				}

				var sum = posList.Count-1;

				posList.Add(n + 1);

				if(sum<s)
				{
                    Console.WriteLine(-1);
					continue;
                }

				if (sum == s)
				{
                    Console.WriteLine(0);
					continue;
                }

				var maxsize = 0;

				for (int j = 0;j < posList.Count-s-1; j++)
				{
					maxsize = Math.Max(maxsize, posList[j + s+1] - posList[j]);
				}

                Console.WriteLine(n+1-maxsize);
            }
		}
    }
}
