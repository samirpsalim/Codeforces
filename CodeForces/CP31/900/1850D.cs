namespace Leetcode.CodeForces.CP31._900
{
    internal class _1850D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, k) = (arr[0], arr[1]);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                Array.Sort(a);

                var maxlen = 1;
                var curlen = 1;

                for(int j=1; j<n; j++)
                {
                    if (a[j] - a[j - 1] > k) curlen = 1;
                    else curlen++;

                    maxlen = maxlen < curlen ? curlen : maxlen;
                }

                Console.WriteLine(n-maxlen);
            }
        }
    }
}
