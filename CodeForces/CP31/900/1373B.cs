namespace Leetcode.CodeForces.CP31._900
{
    internal class _1373B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var s = Console.ReadLine();

                var ones = s!.Count(c => c == '1');
                var zeroes = s!.Length - ones;

                Console.WriteLine(Math.Min(ones,zeroes)%2 ==0 ? "NET" : "DA");
            }
        }
    }
}
