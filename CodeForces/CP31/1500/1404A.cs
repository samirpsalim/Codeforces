namespace Leetcode.CodeForces.CP31._1500
{
    internal class _1404A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);
            
            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n,k) = (arr[0],arr[1]);

                string s = Console.ReadLine()!;

                var onecount = 0;
                var zerocount = 0;

                var conflict = false;

                for(int j=0; j<k; j++)
                {
                    var curval = s[j];

                    for(int j2=j+k;j2<n; j2+=k)
                    {
                        if(curval =='?') curval = s[j2];
                        else if (s[j2] == '?') continue;
                        else if(curval != s[j2])
                        {
                            conflict = true;
                            break;
                        }
                    }

                    if(conflict) break;

                    if(curval == '1')
                    {
                        onecount++;
                        if(onecount >k) break;
                    }
                    else if (curval == '0')
                    {
                        zerocount++;
                        if (zerocount > k) break;
                    }
                }

                Console.WriteLine(!conflict && onecount<=k/2 && zerocount<=k/2 ? "YES" : "NO");
            }
        }
    }
}
