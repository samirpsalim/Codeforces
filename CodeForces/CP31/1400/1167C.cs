namespace Leetcode.CodeForces.CP31._1400
{
    internal class DSU
    {
        private readonly int[] parent;
        private readonly int[] size;

        public DSU(int n)
        {
            parent = new int[n + 1];
            size = new int[n + 1];

            for (int i = 0; i <= n; i++)
            {
                parent[i] = i; 
                size[i] = 1;  
            }
        }

        public int Find(int x)
        {
            if (parent[x] ==x) return x;

            return parent[x] = Find(parent[x]);
        }

        public bool Union(int a , int b)
        {
            var rootA = Find(a);
            var rootB = Find(b);

            if(rootA == rootB) return false;

            if (size[rootA] < size[rootB]) (rootA, rootB) = (rootB, rootA);

            parent[rootB] = rootA;
            size[rootA] += size[rootB];
            
            return true;
        }

        public int GetSize(int x)
        {
            return size[Find(x)];
        }
    }

    internal class _1167C
    {
        static void Solve(string[] args)
        {
            var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var (n,m) = (arr[0],arr[1]);

            var dsu = new DSU(n);

            for(int i=0; i<m; i++)
            {
                arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                if (arr[0]>=2)
                {
                    for(int j=2; j <= arr[0];++j)
                    {
                        dsu.Union(arr[1], arr[j]);
                    }
                }
            }

            Console.WriteLine(string.Join(' ',Enumerable.Range(1,n).Select(x=> dsu.GetSize(x))));
        }
    }
}
