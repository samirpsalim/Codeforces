namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1690D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, k) = (arr[0], arr[1]);

                string s = Console.ReadLine()!;

                var blackcount = 0;

                for(int j=0; j<k;++j)
                {
                    if(s[j] == 'B')
                    {
                        blackcount++;
                    }
                }
                
                if(blackcount == k)
                {
                    Console.WriteLine(0);
                    continue;
                }

                var ans = k-blackcount;

                for(int j=k;j<n;++j)
                {
                    if (s[j]== 'B' && s[j-k]=='W')
                    {
                        blackcount++;
                        if(blackcount==k)
                        {
                            ans = 0;
                            break;
                        }
                        else if(k-blackcount<ans)
                        {
                            ans = k-blackcount;
                        }
                    }
                    else if(s[j] == 'W' && s[j - k] == 'B')
                    {
                        blackcount--;
                    }
                }

                Console.WriteLine(ans);
            }
        }
    }
}
