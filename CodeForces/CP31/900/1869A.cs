namespace Leetcode.CodeForces.CP31._900
{
    internal class _1869A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                Console.ReadLine();
                if(n%2 == 1)
                {
                    Console.WriteLine($"4\n1 {n}\n2 {n}\n1 2\n1 2");
                }
                else
                {
                    Console.WriteLine($"2\n1 {n}\n1 {n}");
                }
            }
        }
    }
}
