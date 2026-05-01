namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1917B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);
            var ispresent = new bool[26];

            for (int i = 0; i < t; i++)
            {
                Array.Fill(ispresent, false);
                var n = int.Parse(Console.ReadLine()!);
                string s = Console.ReadLine()!;
                var lettersfound = 0;
                var ans = 0;

                for(int j=0; j<n; j++)
                {
                    if(!ispresent[s[j]-97])
                    {
                        ispresent[s[j] - 97] = true;
                        lettersfound++;
                        ans += (n - j);

                        if(lettersfound ==26)
                        {
                            break;
                        }
                    }
                }

                Console.WriteLine(ans);
            }
        }
    }
}
