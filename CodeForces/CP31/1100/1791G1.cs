namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1791G1
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, c) = (arr[0], arr[1]);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                for(int j =0; j<n; j++)
                {
                    a[j] += j+1;
                }

                Array.Sort(a);

                var total = 0;
                var count = 0;

                foreach(var aj in a)
                {
                    if(total+aj<=c)
                    {
                        count++;
                        total += aj;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine(count);
            }
        }
    }
}
