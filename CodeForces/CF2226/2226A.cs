namespace Leetcode.CodeForces.CF2226
{
    internal class _2226A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                var ans = 0;
                var isOnOne = false;

                for(int j = 0; j < n; j++)
                {
                    if (a[j]==1)
                    {
                        isOnOne=true;
                    }
                    else
                    {
                        ans = (ans + a[j]) % 676767677;
                        isOnOne = false;
                    }
                }

                if(isOnOne)
                    ans = (ans + 1) % 676767677;

                Console.WriteLine(ans);
            }
        }
    }
}
