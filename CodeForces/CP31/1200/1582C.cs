namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1582C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var s = Console.ReadLine()!;

                var ans = -1;

                for (int j = 0; j < 26; j++)
                {
                    var c = (char)('a' + j);

                    var l = 0;
                    var r = n - 1;
                    var flag = false;
                    var count = 0;

                    while (l < r)
                    {
                        if (s[l] == s[r])
                        {
                            l++;
                            r--;
                        }
                        else if (s[l] == c)
                        {
                            l++;
                            count++;
                        }
                        else if (s[r] == c)
                        {
                            r--;
                            count++;
                        }
                        else
                        {
                            flag = true;
                            break;
                        }
                    }

                    if(!flag)
                    {
                        ans = ans ==-1 || count<ans? count: ans; 
                    }
                }

                Console.WriteLine(ans);
            }
        }
    }
}
