namespace Leetcode.CodeForces.CF2227
{
    internal class _2227A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                Console.WriteLine(a[0]%2==0 || a[1]%2==0 ? "YES" : "NO");
            }
        }
    }
}
