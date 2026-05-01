namespace Leetcode.CodeForces.CP31._1100
{
    internal record IndexedNum(int val,int idx);
    internal class _1904B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for(int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var ans = new int[n];

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).Select((ai,idx)=>new IndexedNum(ai,idx))
                        .OrderByDescending(num => num.val).ToArray();

                var prefsum = a.Sum(num => (long)num.val)-a[0].val;
                var lastans = n - 1;
                ans[a[0].idx] = n - 1;

                for(int j = 1; j < n; j++)
                {
                    if (prefsum < a[j-1].val && a[j - 1].val != a[j].val)
                    {
                        lastans = n - 1 - j;
                    }
                    prefsum -= a[j].val;
                    ans[a[j].idx] = lastans;
                }

                Console.WriteLine(string.Join(' ',ans));
            }
        }
    }
}
