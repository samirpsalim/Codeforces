namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1520E
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var s = Console.ReadLine()!.Trim('.');

                n = s.Length;

                if (n == 0 || n == 1)
                {
                    Console.WriteLine(0);
                    continue;
                }

                var prefmovecost = new long[n];
                var suffmovecost = new long[n];

                var cursheepcount = 1;

                for(int j=1; j<n; j++)
                {
                    if (s[j]=='.')
                    {
                        prefmovecost[j]= prefmovecost[j-1]+cursheepcount;
                    }
                    else
                    {
                        prefmovecost[j] = prefmovecost[j - 1];
                        cursheepcount++;
                    }
                }

                cursheepcount = 1;

                for (int j = n-2; j >=0; j--)
                {
                    if (s[j] == '.')
                    {
                        suffmovecost[j] = suffmovecost[j + 1] + cursheepcount;
                    }
                    else
                    {
                        suffmovecost[j] = suffmovecost[j + 1];
                        cursheepcount++;
                    }
                }

                var ans = long.MaxValue;

                for (int j = 0; j < n; j++)
                {
                    ans = Math.Min(ans, prefmovecost[j] + suffmovecost[j]);
                }

                Console.WriteLine(ans);
            }
        }
    }
}
