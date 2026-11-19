namespace Leetcode.CodeForces.CP31._1600
{
    internal class _1778C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n,k) = (arr[0],arr[1]);

                string a = Console.ReadLine()!;
                string b = Console.ReadLine()!;

                var diffarr = new List<int>(n+2);
                var qSet = new HashSet<char>(10);

                diffarr.Add(-1);

                for(int j=0;j<n;j++)
                {
                    if (a[j] != b[j])
                    {
                        qSet.Add(a[j]);
                        diffarr.Add(j);
                    }
                }
                diffarr.Add(n);

                if(qSet.Count <=k)
                {
                    Console.WriteLine((long)n*(n+1)/2);
                    continue;
                }

                var qArr = qSet.ToArray();
                var qKey = new int[k];

                for (int j = 0; j < k; j++) qKey[j] = j;

                var ans = 0L;

                do
                {
                    qSet.Clear();
                    for (int j = 0;j < k; j++) qSet.Add(qArr[qKey[j]]);

                    var prev = -1;
                    var curans = 0L;

                    for (int j = 1; j< diffarr.Count; j++)
                    {
                        if (j == diffarr.Count - 1)
                        {
                            curans += SumTill(diffarr[j] - prev - 1);
                            continue;
                        }
                        if (!qSet.Contains(a[diffarr[j]]))
                        {
                            curans += SumTill(diffarr[j] - prev - 1);
                            prev = diffarr[j];
                        }
                    }

                    if(curans > ans) ans = curans;

                }while(GoToNext(ref qKey,qArr.Length));

                Console.WriteLine(ans);
            }
        }

        private static bool GoToNext(ref int[] qKey, int elemCount)
        {
            var k = qKey.Length;
            var stidx = k;

            do
            {
                stidx--;
                if (stidx == -1) break;
                qKey[stidx]++;

            } while (qKey[stidx] > (elemCount - k + stidx));

            if(stidx == -1) return false;

            for (int j = stidx+1; j < k; j++)
            {
                qKey[j] = qKey[j - 1] + 1;
            }
            return true;
        }

        private static long SumTill(long n)
        {
            return n * (n + 1) / 2;
        }
    }
}