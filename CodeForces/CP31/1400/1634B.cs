namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1634B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for(int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(long.Parse).ToArray();

                var(n,x,y) = (arr[0], arr[1], arr[2]);

                var parity = (x + y) % 2;

                parity = Console.ReadLine()!.Split(' ').Select(int.Parse)
                         .Aggregate(parity,(par,ai) => (par+(ai%2))%2);

                Console.WriteLine(parity%2==0?"Alice":"Bob");
            }
        }
    }
}
