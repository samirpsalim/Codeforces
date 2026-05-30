namespace Leetcode.CodeForces.CF2232
{
    internal class _2232A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).Order().ToArray();

                if(n%2 == 0)
                {
                    if (a[n / 2] != a[n/2-1])
                    {
                        Console.WriteLine(n/2);
                    }
                    else
                    {
                        var med = a[n / 2];
                        var less = 0;
                        var eq = 0;

                        foreach(var ai in a)
                        {
                            if (ai < med) less++;
                            else if (ai == med) eq++;
                            else break;
                        }

                        Console.WriteLine(Math.Max(less,n-less-eq));
                    }
                }
                else
                {
                    var med = a[n / 2];
                    var less = 0;
                    var eq = 0;

                    foreach (var ai in a)
                    {
                        if (ai < med) less++;
                        else if (ai == med) eq++;
                        else break;
                    }

                    Console.WriteLine(Math.Max(less, n - less - eq));
                }
            }

        }
    }
}
