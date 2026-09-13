namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1771B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n,m) = (arr[0], arr[1]);

                int[] lastToIgnore = new int[n];

                for(int j=0; j<m; j++)
                {
                    arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                    var (v,k) = (arr[0], arr[1]);

                    if(v>k) (k,v) = (v,k);

                    lastToIgnore[k-1] = Math.Max(lastToIgnore[k-1],v);
                }

                var ans = 0L;

                var curmax= lastToIgnore[0];

                for(int j=0; j<n;j++)
                {
                    curmax = Math.Max (curmax, lastToIgnore[j]);
                    ans += j + 1 - curmax;
                }

                Console.WriteLine(ans);
            }
        }
    }
}
