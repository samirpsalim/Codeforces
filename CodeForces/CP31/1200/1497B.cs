namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1497B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, m) = (arr[0], arr[1]);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var dict = new Dictionary<int, int>();

                for (int j = 0; j < n; j++)
                {
                    var mod = a[j]%m;

                    if (dict.ContainsKey(mod)) dict[mod]++;
                    else dict[mod] = 1;
                }

                var ans = 0;
                if (dict.ContainsKey(0)) ans++;
                if(m%2==0 && dict.ContainsKey(m/2)) ans++;

                for (int j = 1;2*j <m; j++)
                {
                    var first = dict.TryGetValue(j, out var val) ? val : 0;
                    var second = dict.TryGetValue(m-j, out val) ? val : 0;
                    var min = Math.Min(first, second);
                    var max = Math.Max(first, second);


                    if (min == max && min == 0) continue;
                    if (min + 1 >= max) ans++;
                    else ans += max - min;
                }

                Console.WriteLine(ans);

            }
        }
    }
}
