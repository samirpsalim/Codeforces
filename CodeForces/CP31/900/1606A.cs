namespace Leetcode.CodeForces.CP31._900
{
    internal class _1606A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var s = Console.ReadLine();

                Console.WriteLine(s!.Substring(0,s.Length-1)+s[0]);
            }
        }
    }
}
