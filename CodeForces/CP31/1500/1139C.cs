

namespace Leetcode.CodeForces.CP31._1500
{
    internal class DSU
    {
        private int[] parent;
        private int[] size;

        public DSU(int n)
        {
            parent = new int[n];
            size = new int[n];
            for (int i = 0; i < n; i++)
            {
                parent[i] = i;
                size[i] = 1;
            }
        }

        public int Find(int x)
        {
            if (parent[x] == x) return x;

            parent[x] = Find(parent[x]);
            return parent[x];
        }

        public int Size(int x)
        {
            return size[Find(x)];
        }

        public void Union(int x, int y)
        {
            var rootx = Find(x);
            var rooty = Find(y);

            size[rootx] += size[rooty];
            parent[rooty] = rootx;
        }
    }

    internal class _1139C
    {
        static void Solve(string[] args)
        {
            var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var (n,k) = (arr[0],arr[1]);

            var dsu = new DSU(n);

            for (int i = 0;i < n-1;i++)
            {
                arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                if (arr[2]==0)
                {
                    dsu.Union(arr[0] - 1, arr[1] - 1);
                }
            }

            var ans = 0L;

            for (int i = 0; i < n;i++)
            {
                if (dsu.Find(i) == i) ans = (ans + ModPow(dsu.Size(i),k)) % 1_000_000_007;
            }

            Console.WriteLine(ModDiff(ModPow(n,k),ans));
        }

        private static long ModDiff(long x, long y)
        {
            if (x >= y) return x - y;

            return x + 1_000_000_007 - y;
        }

        private static long ModPow(int i, int k)
        {
            var ans = 1;

            for (int j = 0; j < k; j++)
            {
                ans = (ans*i) % 1_000_000_007;
            }
            return ans;
        }
    }
}
