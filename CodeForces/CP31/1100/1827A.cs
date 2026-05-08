namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1827A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse)
                        .OrderDescending().ToArray();

                var b = Console.ReadLine()!.Split(' ').Select(int.Parse)
                        .OrderDescending().ToArray();

                if (a[n-1]<=b[n-1])
                {
                    Console.WriteLine(0);
                    continue;
                }

                var aptr = 0;
                var ans = 1L;
                for(int bptr=0; bptr<n-1;++bptr)
                {
                    while(aptr<n)
                    {
                        if (a[aptr]<=b[bptr])
                        {
                            break;
                        }
                        aptr++;
                    }
                    ans = (ans * (aptr - bptr)) % 1_000_000_007;
                }
                Console.WriteLine(ans);
            }
        }
    }
}
