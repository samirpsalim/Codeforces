namespace Leetcode.CodeForces.CP31._900
{
    internal class _1837B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var s = Console.ReadLine()!;

                var maxlen = 1;
                var curlen = 1;

                for(int j=1; j<n;++j)
                {
                    if (s[j]== s[j-1])
                    {
                        curlen++;
                        maxlen = curlen> maxlen ? curlen : maxlen;
                    }
                    else
                    {
                        curlen = 1;
                    }
                }

                Console.WriteLine(maxlen+1);
            }
        }
    }
}
