namespace Leetcode.CodeForces.CP31._800
{
    internal class _1845A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, k, x) = (a[0], a[1], a[2]);

                var impossible = k == 1 || (x == 1 && k == 2 && n % 2 == 1);

                Console.WriteLine(impossible ? "NO" : "YES");

                if (!impossible)
                {
                    if(x!=1)
                    {
                        Console.WriteLine(n);
                        Console.WriteLine(
                            string.Join(' ',
                            Enumerable.Range(0,n).Select(x=>1)
                            ));
                    }
                    else if(n%2==0)
                    {
                        Console.WriteLine(n/2);
                        Console.WriteLine(
                            string.Join(' ',
                            Enumerable.Range(0, n/2).Select(x => 2)
                            ));
                    }
                    else
                    {
                        Console.WriteLine(n / 2);
                        Console.WriteLine($"{3} {
                            string.Join(' ',
                            Enumerable.Range(0, n / 2-1).Select(x => 2)
                            )}");
                    }
                }
            }
        }
    }
}
