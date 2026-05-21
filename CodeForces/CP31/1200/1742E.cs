namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1742E
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, q) = (arr[0], arr[1]);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var k = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var maxes = new int[n + 1];
                var sums = new long[n + 1];

                for(int j=0; j < n; j++)
                {
                    maxes[j+1] = Math.Max(maxes[j], a[j]);
                    sums[j+1] = sums[j] + a[j];
                }

                var ans = new long[q];

                for(int j=0; j < q; ++j)
                {
                    var start = 0;
                    var end = n;
                    var mid = start + (end - start)/2;
                    
                    while(start < end)
                    {
                        if(maxes[mid] > k[j])
                        {
                            end = mid - 1;
                        }
                        else
                        {
                            start = mid;
                        }

                        mid = start + (end + 1 - start)/2;
                    }

                    ans[j] = sums[mid];
                }

                Console.WriteLine(string.Join(" ", ans));
            }
        }
    }
}
