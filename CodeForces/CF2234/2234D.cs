namespace Leetcode.CodeForces.CF2234
{
    internal class _2234D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                var (n, k) = (arr[0], arr[1]);

                string a1 = Console.ReadLine()!;
                string am = Console.ReadLine()!;

                var tot = (1 << k) + 1;
                var ans = 0L;

                var x1 = a1.LongCount(c => c == '1');
                var y1 = n - x1;

                var xm = am.LongCount(c => c == '1');
                var ym = n - xm;

                var xmid = Enumerable.Range(0, n).Where(i => a1[i] != am[i]).LongCount();
                var ymid = n - xmid;

                if(tot%3==0)
                {
                    var comcount = tot / 3;

                    ans += comcount * x1 * y1;
                    ans += comcount * xmid * ymid;
                    ans += comcount * xm * ym;
                }
                else
                {
                    var comcount = tot / 3;

                    ans += comcount * xmid * ymid;

                    comcount++;    

                    ans += comcount * x1 * y1;
                    ans += comcount * xm * ym;
                }

                Console.WriteLine(ans);
            }
        }
    }
}
