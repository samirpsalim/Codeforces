namespace Leetcode.CodeForces.CP31._800
{
    internal class _1899A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                Console.WriteLine(n%3==0? "Second" : "First");
            }
        }
    }
}
