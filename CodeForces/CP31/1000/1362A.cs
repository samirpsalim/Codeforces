namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1362A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                var (a,b)= arr[0] > arr[1]? (arr[1], arr[0]) : (arr[0], arr[1]);

                if(a==b)
                {
                    Console.WriteLine(0);
                    continue;
                }
                if (b % a != 0)
                {
                    Console.WriteLine(-1);
                    continue;
                }
                if (a == 1 && b % 2 != 0)
                {
                    Console.WriteLine(-1);
                    continue;
                }

                var ans = 0;
                int j;
                for(j=0; j<64; j++)
                {
                    a *= 2;
                    ans++;
                    if (a == b) break;
                }
                if(j==64)
                {
                    Console.WriteLine(-1);
                    continue;
                }

                Console.WriteLine(ans/3 + (ans%3==0?0:1));
            }
        }
    }
}
