namespace Leetcode.CodeForces.CP31._800
{
    internal class _1805A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var aggxor = Console.ReadLine()!.Split(' ').Select(int.Parse).Aggregate(0,(acc,ai)=>acc^ai);

                if (n % 2 == 1 || aggxor ==0) Console.WriteLine(aggxor);
                else Console.WriteLine(-1);
            }
        }
    }
}
