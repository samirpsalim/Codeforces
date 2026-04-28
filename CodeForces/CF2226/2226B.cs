namespace Leetcode.CodeForces.CF2226
{
    internal class _2226B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var ans = 0;

                for(int j=0; j<n-1; j++)
                {
                    var diff = a[j] > a[j + 1] ? a[j] - a[j + 1] : a[j+1] - a[j];

                    if (a[j]%diff==0 && a[j+1]%diff==0)
                    {
                        ans++;
                    }
                }

                Console.WriteLine(ans);
            }
        }
    }
}
