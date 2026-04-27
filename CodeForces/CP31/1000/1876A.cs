namespace Leetcode.CodeForces.CP31._1000
{
    internal record Villager(long a, long b);

    internal class _1876A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);
            
            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                var (n, p) = (arr[0], arr[1]);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                var b = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var villagers = Enumerable.Range(0,(int)n).Select(i => new Villager(a[i], b[i]))
                                .OrderBy(v=> v.b).ThenByDescending(v=> v.a).ToArray();

                long ans = villagers[0].b > p ? n * p : p;
                long covered = villagers[0].b > p ? n : 1;
                var j = 0;

                while(covered<n)
                {
                    if (villagers[j].b > p)
                    {
                        ans += (n - covered) * p;
                        covered = n;
                    }
                    if (villagers[j].a < n - covered)
                    {
                        covered += villagers[j].a;
                        ans += villagers[j].a * villagers[j].b;
                    }
                    else
                    {
                        ans += (n-covered)* villagers[j].b;
                        covered = n;
                    }
                    j++;
                }
                Console.WriteLine(ans);

            }
        }
    }
}
