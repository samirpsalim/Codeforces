namespace Leetcode.CodeForces.CF2259
{
    internal class _2259A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for(int _=0; _ < t; _++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, k) = (arr[0], arr[1]);

                string s = Console.ReadLine()!;

                var ans = n/k;

                for (int i = 0; i < n / k; i++)
                {
                    for (int j = i * k; j < (i + 1) * k; j++)
                    {
                        if (s[j]=='0')
                        {
                            ans--;
                            break;
                        }
                    }
                }

                Console.WriteLine(ans);
            }

        }
    }
}
