namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1420B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var dict = new Dictionary<int, int>();

                foreach(var ai in a)
                {
                    var top = 2;

                    while (ai / top != 0)
                    {
                        top *= 2;
                    }

                    if (dict.ContainsKey(top)) dict[top]++;
                    else dict[top] = 1;
                }

                var ans = 0L;

                foreach(var num in dict.Values)
                {
                    ans += (long)num * (num - 1) / 2;
                }
                Console.WriteLine(ans);
            }
        }
    }
}
