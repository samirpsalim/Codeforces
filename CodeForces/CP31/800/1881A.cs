namespace Leetcode.CodeForces.CP31._800
{
    internal class _1881A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var lens = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, m) = (lens[0], lens[1]);

                var x = Console.ReadLine();
                var s = Console.ReadLine();

                var reqsize = ((m - 1) / n) + ((n + m - 1) % n == 0 ? 1 : 2);

                var repeatedx = string.Concat(Enumerable.Repeat(x, reqsize));

                var index = repeatedx.IndexOf(s!);

                if(index == -1)
                {
                    Console.WriteLine(-1);
                    continue;
                }

                var reps = (index + s!.Length) / n + ((index + s!.Length) % n ==0 ? 0 :1);

                Console.WriteLine(Math.Ceiling(Math.Log2(reps)));
            }
        }
    }
}
