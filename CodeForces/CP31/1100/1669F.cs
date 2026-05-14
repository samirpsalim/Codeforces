namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1669F
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var w = Console.ReadLine()!.Split(' ').Select(int.Parse)
                        .ToArray();

                var ans = 0;

                var aliceend = 0;
                var bobend = n-1;

                var aliceweight = w[0];
                var bobweight = w[n - 1];

                while(aliceend<bobend)
                {
                    if(aliceweight == bobweight)
                    {
                        ans = aliceend + 1 + n - bobend;
                        aliceend++;
                        bobend--;
                        bobweight += w[bobend];
                        aliceweight += w[aliceend];
                    }
                    else if (bobweight < aliceweight)
                    {
                        bobend--;
                        bobweight += w[bobend];
                    }
                    else
                    {
                        aliceend++;
                        aliceweight += w[aliceend];
                    }
                }

                Console.WriteLine(ans);
            }
        }
    }
}
