namespace Leetcode.CodeForces.CF2234
{
    internal class _2234C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var h = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var ans = new long[n];

                for (int j = 0; j < n; j++)
                {
                    int[] p = [(n+j - 1) % n, j];
                    var prev = h[(n+j - 1) % n];
                    var next = h[j];
                    ans[j] = 0;

                    for (int k = 0; k < n-1; k++)
                    {
                        var dir = prev < next ? -1 : 1;

                        if(dir == -1)
                        {
                            ans[j] += prev;
                            p[0] = (n+p[0]-1) %n;
                            prev = Math.Max(prev, h[p[0]]);
                        }
                        else
                        {
                            ans[j] += next;
                            p[1] = (p[1] + 1) % n;
                            next = Math.Max(next, h[p[1]]);
                        }
                        
                    }
                }

                Console.WriteLine(string.Join(' ',ans));
            }
        }
    }
}
