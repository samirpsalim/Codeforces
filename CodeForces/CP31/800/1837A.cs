namespace Leetcode.CodeForces.CP31._800
{
    internal class _1837A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (x, k) = (a[0], a[1]);

                if(x%k==0)
                {
                    Console.WriteLine(2);
                    Console.WriteLine($"{1} {x-1}");
                }
                else
                {
                    Console.WriteLine(1);
                    Console.WriteLine(x);
                }
            }
        }
    }
}
