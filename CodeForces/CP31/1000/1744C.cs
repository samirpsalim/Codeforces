namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1744C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ');

                var (n,c) = (int.Parse(arr[0]), arr[1][0]);

                var s = Console.ReadLine()!;

                if(c=='g')
                {
                    Console.WriteLine(0);
                    continue;
                }

                s = s + s;
                var lastg = int.MaxValue;
                var maxdist = int.MinValue;

                for(int j=2*n-1; j>=0; j--)
                {
                    if(s[j]==c && lastg!=int.MaxValue)
                    {
                        maxdist = Math.Max(maxdist, lastg - j);
                    }
                    else if (s[j]=='g')
                    {
                        lastg = j;
                    }
                }
                Console.WriteLine(maxdist);
            }
        }
    }
}
