namespace Leetcode.CodeForces.CP31._1600
{
    internal class _1833E
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var dsu = new int[n + 1];

                for (int j = 0; j < n + 1; j++) dsu[j] = j;

                var openOnes = 0;

                for (int j = 0; j <n; j++)
                {
                    if (a[a[j] - 1] == j + 1) openOnes++;

                    dsu[j+1] = Find(dsu, a[j]);
                }

                openOnes /= 2;

                var sets = new HashSet<int>();

                for (int j = 1;j <= n; j++)
                {
                    sets.Add(Find(dsu, j));
                }

                var min = openOnes == 0 ? sets.Count : sets.Count + 1 - openOnes;

                Console.WriteLine($"{min} {sets.Count}");
            }
        }

        private static int Find(int[] dsu, int x)
        {
            if (dsu[x] == x) return x;

            dsu[x] = Find(dsu, dsu[x]);
            return dsu[x];
        }
    }
}
