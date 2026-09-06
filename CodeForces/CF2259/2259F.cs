namespace Leetcode.CodeForces.CF2259
{
    internal class _2259F
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {

                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                string s = Console.ReadLine()!;

                var onecount = a.AsSpan().Count(1);
                var zerocount = n - onecount;

                var firstone = a.AsSpan().IndexOf(1);
                var lastzero = a.AsSpan().LastIndexOf(0);

                var misplacedzeroes = zerocount - firstone;
                var misplacedones = onecount - (n - 1 - lastzero);

                var ans = new long[n + 1];
                var leftzerocount = misplacedzeroes;

                if(firstone!=-1 && lastzero!=-1)
                {
                    for (int j = firstone; j <= lastzero; ++j)
                    {
                        if (a[j] == 0) leftzerocount--;
                        else ans[0] += leftzerocount;
                    }

                    for (int j = 0; j < n; ++j)
                    {
                        if (s[j] == '0')
                        {
                            ans[j + 1] = ans[j] - misplacedones;
                            misplacedzeroes--;

                            while (lastzero > firstone)
                            {
                                lastzero--;
                                if (lastzero < 0 || a[lastzero] == 0) break;
                                else misplacedones--;
                            }
                        }
                        else
                        {
                            ans[j + 1] = ans[j] - misplacedzeroes;
                            misplacedones--;

                            while (lastzero > firstone)
                            {
                                firstone++;
                                if (firstone >= n || a[firstone] == 1) break;
                                else misplacedzeroes--;
                            }
                        }

                        if (lastzero <= firstone) break;
                    }
                }

                Console.WriteLine(string.Join(' ', ans));

            }
        }
    }
}
