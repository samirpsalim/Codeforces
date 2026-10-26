namespace Leetcode.CodeForces.CP31._1500
{
    internal class _1325C
    {
        static void Solve(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

            var deg = new int[n];

            var edges = new int[n][];

            for (int i = 0; i < n - 1; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                deg[arr[0] - 1]++;
                deg[arr[1] - 1]++;

                edges[i] = arr;
            }

            if(deg.Where(x=> x==1).Count() > 2)
            {
                var start = 0;
                var end = n-2;

                for (int i = 0;i < n - 1;i++)
                {
                    var e = edges[i];

                    if(deg[e[0]-1]==1 || deg[e[1]-1]==1)
                    {
                        Console.WriteLine(start);
                        start++;
                    }
                    else
                    {
                        Console.WriteLine(end);
                        end--;
                    }
                }
            }
            else
            {
                for (int i = 0; i<n-1; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
