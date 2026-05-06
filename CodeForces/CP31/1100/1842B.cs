namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1842B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, x) = (arr[0], arr[1]);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                var b = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
                var c = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var aor = 0;
                var bor = 0;
                var cor = 0;

                int j, k, l;
                bool flag = false;

                for (j=0; j<n; j++)
                {
                    if ((a[j] & ~x) != 0)
                    {
                        break;
                    }

                    aor=aor | a[j];
                }

                for (j = 0; j < n; j++)
                {
                    if ((b[j] & ~x) != 0)
                    {
                        break;
                    }

                    bor = bor | b[j];
                }

                for (j = 0; j < n; j++)
                {
                    if ((c[j] & ~x) != 0)
                    {
                        break;
                    }

                    cor = cor | c[j];
                }

                flag = (aor | bor | cor) == x;

                Console.WriteLine(flag? "YES" : "NO");
            }

        }
    }
}
