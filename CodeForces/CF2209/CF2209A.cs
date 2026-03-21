namespace Leetcode.CodeForces.CF2209
{
    internal class CF2209A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);
            long n, c, k;

            for (int i = 0; i < t; i++)
            {
                var inputs = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();
                (n,c,k) = (inputs[0], inputs[1],inputs[2]);

                var a = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                Array.Sort(a);

                for(int j = 0; j < n; j++)
                {
                    if (a[j]>c)
                    {
                        break;
                    }
                    else if (a[j] + k <= c)
                    {
                        c+= a[j]+k;
                        k = 0;
                    }
                    else
                    {
                        k= k+a[j]-c;
                        c *= 2;
                    }

                }

                Console.WriteLine(c);

            }
        }
    }
}
