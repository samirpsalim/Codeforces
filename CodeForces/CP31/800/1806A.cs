namespace Leetcode.CodeForces.CP31._800
{
    internal class _1806A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (a,b,c,d) = (arr[0], arr[1], arr[2], arr[3]);

                if(d<b || a+d<b+c)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    Console.WriteLine(a+2*d-2*b-c);
                }
            }
        }
    }
}
