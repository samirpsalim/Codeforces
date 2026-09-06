namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1878E
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var prefs = new int[n+1, 32];

                for (int j = 0; j < n; j++)
                {
                    for(int k = 0; k < 32; k++)
                    {
                        var prefcur = (a[j]&(1<<k))>>k;

                        prefs[j+1,k] = j==0? prefcur : prefs[j,k] +prefcur;
                    }
                }

                var q = int.Parse(Console.ReadLine()!);

                var ans = new int[q];

                for(int j=0; j<q; j++)
                {
                    var arr = Console.ReadLine()!.Split(' ').Select(int.Parse)
                                .ToArray();

                    var (l,k) = (arr[0],arr[1]);

                    var and = a[l-1];

                    if (and < k)
                    {
                        ans[j] = -1;
                    }
                    else
                    {
                        var start = l;
                        var end = n;
                        var mid=(start+end+1)/2;

                        while (start <end)
                        {
                            var curand = 0;

                            for(int idx=0; idx <32;++idx)
                            {
                                if (prefs[mid, idx] - prefs[l - 1, idx] 
                                    == mid + 1 - l)
                                {
                                    curand += (1 << idx);
                                }
                            }

                            if (curand >= k)
                            {
                                start = mid;
                            }
                            else
                            {
                                end = mid - 1;
                            }
                            mid = (start + end + 1) / 2;
                        }

                        ans[j] = mid;
                    }
                }

                Console.WriteLine(string.Join(" ", ans));
            }
        }
    }
}
