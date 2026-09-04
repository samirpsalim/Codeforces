namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1904C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n,k) = (arr[0],arr[1]);

                var a = Console.ReadLine()!.Split(' ').Select(long.Parse).Order().ToArray();

                if(k>=3)
                {
                    Console.WriteLine(0);
                }
                else if(k==1)
                {
                    var min = a[0];

                    for(int j=1; j<n; j++)
                    {
                        if (a[j] - a[j - 1] < min) min = a[j] - a[j - 1];
                    }
                    Console.WriteLine(min);
                }
                else
                {
                    var min = a[0];

                    for(int j=0; j<n-1; j++)
                    {
                        if (min == 0) break;
                        for(int l=j+1; l<n; l++)
                        {
                            var cur = a[l]-a[j];

                            if(cur < min) min = cur;

                            var start = 0;
                            var end = n - 1;

                            var mid = (start + end + 1) / 2;
                            var curmindiff = long.MaxValue;

                            while (start < end)
                            {
                                if (a[mid] == cur)
                                {
                                    min = 0;
                                    break;
                                }
                                else if (a[mid] < cur)
                                {
                                    start = mid;
                                }
                                else
                                {
                                    curmindiff = curmindiff < a[mid] - cur ? curmindiff : a[mid] - cur;
                                    end = mid - 1;
                                }
                                mid = (start + end + 1) / 2;
                            }

                            curmindiff = curmindiff <= Math.Abs(a[mid] - cur) ? curmindiff : Math.Abs(a[mid] - cur);
                            min = curmindiff > min ? min : curmindiff;
                        }
                    }

                    Console.WriteLine(min);
                }
            }
        }
    }
}
