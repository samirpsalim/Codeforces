namespace Leetcode.CodeForces.CF2259
{
    internal class _2259C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var firstone = -1;
                var lastone = -1;

                for(int j=0; j<n; j++)
                {
                    if (a[j]==-1 || a[j]==1)
                    {
                        if(firstone ==-1)
                        {
                            firstone = j;
                            lastone = j;
                        }
                        else
                        {
                            lastone = j;
                        }
                    }
                }

                for(int j=0; j<n;j++)
                {
                    if (a[j]==-1)
                    {
                        if (j == firstone || j == lastone) a[j] = 1;
                        else a[j] = 0;
                    }
                }

                Console.WriteLine(string.Join(' ',a));
            }
        }
    }
}
