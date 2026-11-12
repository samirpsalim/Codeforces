namespace Leetcode.CodeForces.CP31._1600
{
    internal class _1856C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n,k) = (arr[0],arr[1]);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var start = a.Max();
                var end = start + n;
                var mid = (start + end+1) / 2;

                while(start<end)
                {
                    if (Check(a, mid,k)) start = mid;
                    else end = mid - 1;

                    mid= (start + end+1) / 2;
                }

                Console.WriteLine(mid);
            }
        }

        private static bool Check(int[] a, int x, int k)
        {
            var n = a.Length;

            for (int i = 0;i < n;i++)
            {
                var ops = 0;
                for(int j = i, y=x; j<n; j++,y--)
                {
                    if (y <= a[j]) break;
                    if (j == n - 1)
                    {
                        ops = k + 1;
                        break;
                    }
                    ops += y - a[j];
                    if (ops > k) break;                    
                }
                if (ops <= k) return true;
            }
            return false;
        }
    }
}

