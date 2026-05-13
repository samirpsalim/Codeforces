namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1797B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, k) = (arr[0], arr[1]);

                var a = new int[n][];

                for (int j = 0; j < n; j++)
                {
                    a[j] = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                }

                var diffcount = 0;

                for (int j = 0; 2 * j < n; j++)
                {
                    var last = j != (n - 1 - j) ? 2 * n : n - 1; 
                    for (int l = 0; 2*l < last; l++)
                    {
                        if (a[j][l] != a[n - 1 - j][n - 1 - l])
                        {
                            diffcount++;
                            if (diffcount > k) break;
                        }
                    }
                    if (diffcount > k) break;
                }

                var possible = (diffcount == k) || ((diffcount<k) && 
                    ((n % 2 == 1) || ((k - diffcount) % 2 == 0)));

                Console.WriteLine(possible ? "YES" : "NO");
            }
        }
    }
}
