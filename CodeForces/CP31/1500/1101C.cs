namespace Leetcode.CodeForces.CP31._1500
{
    internal class _1101C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = new (int,int)[n];

                for (int j = 0; j < n; j++)
                {
                    var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                    a[j] = (arr[0],arr[1]);
                }

var asort=a.Select((val,idx) => (val.Item1, val.Item2, idx)).Order().ToArray();

                var ans = new int[n];
                ans[asort[0].Item3] = 1;
                var cur = 1;
                var max = asort[0].Item2;

                for (int j = 1; j < n; j++)
                {
                    var aj = asort[j];
                    if(aj.Item1>max)
                    {
                        cur = 2;
                        max = aj.Item2;
                    }
                    else
                    {
                        max = Math.Max(aj.Item2,max);
                    }
                    ans[aj.Item3] = cur;
                }

                if (cur == 2) Console.WriteLine(string.Join(' ', ans));
                else Console.WriteLine("-1");
            }
        }
    }
}
