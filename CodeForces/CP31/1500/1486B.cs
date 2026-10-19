namespace Leetcode.CodeForces.CP31._1500
{
    internal class _1486B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var x = new int[n];
                var y = new int[n];

                for (int j = 0; j < n; j++)
                {
                    var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                    x[j] = arr[0];
                    y[j] = arr[1];
                }

                if(n%2==1)
                {
                    Console.WriteLine(1);
                    continue;
                }

                Array.Sort(x);
                Array.Sort(y);

                var nr = n / 2;
                var nl = nr - 1;

                var ans = (x[nr] + 1L - x[nl]) * (y[nr] + 1L - y[nl]);

                Console.WriteLine(ans);
            }
        }
    }
}
