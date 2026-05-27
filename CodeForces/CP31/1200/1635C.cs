namespace Leetcode.CodeForces.CP31._1200
{
    internal record Replacement(int x,int y,int z);
    internal class _1635C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a= Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                if (a[n-1] < a[n-2])
                {
                    Console.WriteLine(-1);
                    continue;
                }

                if (a[n - 1] < 0)
                {
                    var flag = false;
                    for(int j=n-2; j >= 0; j--)
                    {
                        if(a[j] > a[j+1])
                        {
                            flag = true;
                            break;
                        }
                    }

                    Console.WriteLine(flag? -1 : 0);
                    continue;
                }

                var ans = new List<Replacement>();

                for(int j=n-3;j >= 0; j--)
                {
                    if (a[j]> a[j+1])
                    {
                        ans.Add(new Replacement(j + 1, j + 2, n));
                        a[j] = a[j + 1] - a[n-1];
                    }
                }

                Console.WriteLine(ans.Count);
                if (ans.Count > 0)
                {
                    Console.WriteLine(string.Join("\n", ans.Select(ai=> $"{ai.x} {ai.y} {ai.z}")));
                }
            }
        }
    }
}
