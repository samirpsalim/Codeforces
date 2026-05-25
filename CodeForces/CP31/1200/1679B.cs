namespace Leetcode.CodeForces.CP31._1200
{
    internal record ReplaceRecord(int replacedAt, int X);
    internal class _1679B
    {
        static void Solve(string[] args)
        {
            var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            var (n, q) = (arr[0], arr[1]);

            var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
            var sum = a.Sum(ai => (long)ai);

            var globalreplace = -1;
            var replacementX = 0;
            var replaceTracker = new Dictionary<int, ReplaceRecord>();

            for(int j  = 0; j < q; j++)
            {
                arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                var t = arr[0];

                if (t == 1)
                {
                    var i = arr[1];
                    var x = arr[2];

                    int prev;

                    if(replaceTracker.TryGetValue(i, out var record))
                    {
                        if (record.replacedAt > globalreplace) prev = record.X;
                        else prev = replacementX;
                    }
                    else
                    {
                        if (globalreplace > -1) prev = replacementX;
                        else prev = a[i - 1];
                    }

                    var diff = x - prev;
                    sum += diff;
                    replaceTracker[i] = new ReplaceRecord(j, x);
                    Console.WriteLine(sum);
                }
                else if (t == 2)
                {
                    var x = arr[1];
                    sum = n * (long)x;
                    Console.WriteLine(sum);

                    globalreplace = j;
                    replacementX = x;
                }
            }
        }
    }
}
