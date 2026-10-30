namespace Leetcode.CodeForces.CP31._1500
{
    internal class _1133D
    {
        static void Solve(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

            var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            var b = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var zerocount = 0;

            var fractdict = new Dictionary<(int, int), int>();

            for (int i = 0; i < n; i++)
            {
                if (a[i] == 0 && b[i] == 0)
                {
                    zerocount++;
                    continue;
                }

                if (a[i] == 0) continue;

                if (b[i] == 0)
                {
                    if (fractdict.ContainsKey((1, 0))) fractdict[(1, 0)]++;
                    else fractdict[(1, 0)] = 1;

                    continue;
                }

                var gcd = GCD(Math.Abs(a[i]), Math.Abs(b[i]));
                var key = a[i] > 0 ? (a[i] / gcd, b[i] / gcd) : (-1 * a[i] / gcd, -1 * b[i] / gcd);

                if (fractdict.ContainsKey(key)) fractdict[key]++;
                else fractdict[key] = 1;
            }
            if (fractdict.Count > 0) zerocount += fractdict.Values.Max();

            Console.WriteLine(zerocount);
        }

        private static int GCD(int a, int b)
        {
            if (a < b) return GCD(b, a);

            if (a % b == 0) return b;

            return GCD(b, a % b);
        }
    }
}
