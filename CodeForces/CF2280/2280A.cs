namespace Leetcode.CodeForces.CF2280
{
    internal class _2280A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n,k) = (arr[0],arr[1]);
                var modval = k % 2;

                var acount = Console.ReadLine()!.Split(' ').Select(int.Parse).Count(ai => ai % 2 == modval);
                var bcount = Console.ReadLine()!.Split(' ').Select(int.Parse).Count(ai => ai % 2 == modval);

                Console.WriteLine(acount <= bcount ? "YES" : "NO");
            }
        }
    }
}
