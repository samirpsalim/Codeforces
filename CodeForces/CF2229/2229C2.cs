namespace Leetcode.CodeForces.CF2229
{
    internal class _2229C2
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var sum = 0L;
                var abssum = 0L;
                var switchpos = 0;

                for (int j = 0; j < n; j++)
                {
                    var cursign = Math.Sign(a[j]);
                    if(cursign >0)
                    {
                        var possum = sum+a[j];
                        var negsum = abssum - a[j];
                        sum = Math.Max(negsum, possum);
                        abssum += a[j];
                        if (negsum >possum)
                        {
                            switchpos = j+1;
                        }
                    }
                    else
                    {
                        sum += a[j];
                        abssum -= a[j];
                    }
                }

                if(switchpos ==0)
                {
                    Console.WriteLine("0\n");
                    continue;
                }

                var ans = new List<int>();

                var sign = -1;

                for (int j = switchpos-2; j >= 0; j--)
                {
                    var cursign = Math.Sign(a[j]);
                    if (cursign != sign)
                    {
                        ans.Add(j + 1);
                        sign = cursign;
                    }
                }

                ans.Add(switchpos);

                Console.WriteLine(ans.Count);
                Console.WriteLine(string.Join(" ", ans));
            }
        }
    }
}
