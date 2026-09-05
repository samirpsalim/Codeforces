namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1883G1
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, m) = (arr[0], arr[1]);

                var c = Console.ReadLine()!.Split(' ').Select(int.Parse).Concat([1]).Order().ToArray();

                var b = Console.ReadLine()!.Split(' ').Select(int.Parse).Order().ToArray();

                var cind = 0;
                var bind = 0;

                while(bind < n)
                {
                    if (c[cind] < b[bind])
                    {
                        cind++;
                        bind++;
                    }
                    else if(bind <n-1)
                    {
                        bind++;
                    }
                    else
                    {
                        cind--;
                        break;
                    }
                }

                Console.WriteLine(bind-cind);

            }
        }
    }
}
