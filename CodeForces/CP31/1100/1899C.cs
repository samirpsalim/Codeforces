

namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1899C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var ans = a[0];

                var cursubarraysum = a[0];

                for(int j=1; j<n; j++)
                {
                    if ((a[j] - a[j-1])%2==0 || cursubarraysum + a[j] < a[j])
                    {
                        cursubarraysum= a[j];
                    }
                    else
                    {
                        cursubarraysum += a[j];
                    }
                    ans = Math.Max(ans,cursubarraysum);
                }

                Console.WriteLine(ans);

            }
        }

        private static List<(int start, int end)> GetSegments(int[] a)
        {
            var start = 0;
            var end = 0;
            var n = a.Length;

            var possiblesegments = new List<(int start, int end)>();

            for (int j = 1; j < n; j++)
            {
                if (a[j] % 2 == a[j - 1] % 2)
                {
                    end = j - 1;
                    possiblesegments.Add((start, end));
                    start = j;
                }
            }

            if (possiblesegments.Last().end != n - 1)
            {
                possiblesegments.Add((start, n - 1));
            }

            return possiblesegments;
        }
    }
}
