namespace Leetcode.CodeForces.CP31._900
{
    internal class _1582B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).
                    Where(ai => ai==0 || ai==1).ToArray();

                long zerocount = a.Count(ai => ai==0);

                Console.WriteLine((a.LongLength-zerocount)*(1L<<(int)zerocount));

            }
        }
    }
}
