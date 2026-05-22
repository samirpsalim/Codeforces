namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1734C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                string s = Console.ReadLine()!;
                var seen = new bool[n];
                var ans = 0l;

                for (int j = 1; j <=n; j++)
                {
                    var start = j - 1;
                    var step = j;

                    for (int k = start; k < n; k+=step)
                    {
                        if (s[k]!='0')
                        {
                            break;
                        }

                        if(!seen[k])
                        {
                            seen[k] = true;
                            ans += j;
                        }
                        
                    }
                }

                Console.WriteLine(ans);
            }
        }
    }
}
