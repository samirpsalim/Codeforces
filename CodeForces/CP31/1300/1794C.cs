namespace Leetcode.CodeForces.CP31._1300
{
    internal class _1794C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToList();

                var ans = new int[n];

                for (int j = 0; j < n; j++)
                {
                    var start = 0;
                    var end = j;
                    var mid = (start + end+1) / 2;

                    while (start < end)
                    {
                        if (a[j-mid] < mid+1)
                        {
                            end = mid-1;
                        }
                        else
                        {
                            start = mid;
                        }
                        mid = (start + end+1) / 2;
                    }

                    ans[j] = mid+1;
                }

                Console.WriteLine(string.Join(' ',ans));
            }
        }
    }
}
