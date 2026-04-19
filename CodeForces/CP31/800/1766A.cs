namespace Leetcode.CodeForces.CP31._800
{
    internal class _1766A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var s = Console.ReadLine();

                Console.WriteLine(9 * (s.Length - 1) + s[0]-48);
            }
        }
    }
}
