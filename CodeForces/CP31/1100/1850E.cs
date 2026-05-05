namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1850E
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                var (n, c) = (arr[0], arr[1]);

                var a = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                var sum = a.Sum();

                var squaresum = a.Sum(ai => ai * ai);

                var det = (sum*sum)+ ((Int128)n)*(c-squaresum);

                var ans = (Sqrt(det)-sum)/(2*n);

                Console.WriteLine(ans);
            }
        }

        private static long Sqrt(Int128 num)
        {
            long start = 1L;
            var end = long.MaxValue <num ? long.MaxValue : (long)num;
            var mid = start +(end-start) / 2;

            while(start <= end)
            {
                Int128 square = (Int128)mid * mid;
                if (square== num)
                {
                    return mid;
                }
                else if(square<num)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
                mid = start + (end - start) / 2;
            }

            return start;
        }
    }
}
