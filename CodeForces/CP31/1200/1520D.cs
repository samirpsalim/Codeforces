namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1520D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var dict = new Dictionary<int, int>();

                for (int j = 0; j < n; j++)
                {
                    var diff = a[j] - j;

                    if(dict.ContainsKey(diff)) dict[diff]++;
                    else dict[diff] = 1;
                }

                var ans = 0L;

                foreach(var v in dict.Values)
                {
                    ans += (long)v * (v - 1) / 2;
                }
                Console.WriteLine(ans);
            }
        }
    }
}
