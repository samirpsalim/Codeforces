namespace Leetcode.CodeForces.CF2179
{
    internal class _2179C
    {
        static void Solve(string[] args)
        {
            int t = int.Parse(Console.ReadLine()!);
            int minval, mink, n;

            for (int i = 0; i < t; i++)
            {
                n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                minval = a.Min();
                mink = int.MaxValue;

                for (int j = 0; j < n; j++) 
                {
                    if (a[j] - minval > 0 && a[j] - minval < mink)
                        mink = a[j] - minval;
                }
                mink = minval > mink ? minval : mink;
                Console.WriteLine(mink);
            }
        }
    }
}
