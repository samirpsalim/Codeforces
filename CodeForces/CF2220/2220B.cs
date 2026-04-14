namespace Leetcode.CodeForces.CF2220
{
    internal class _2220B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);
            int n, m;

            for (int i = 0; i < t; i++)
            {
                var lens = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                (n,m) = (lens[0],lens[1]);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var currep = 1;
                for(int j=1; j < n; j++)
                {
                    if (a[j] == a[j - 1])
                    {
                        currep++;
                        if (currep == m) break;
                    }
                    else
                    {
                        currep = 1;
                    }
                }
                Console.WriteLine(currep == m ? "NO" : "YES");
            }
        }
    }
}
