namespace Leetcode.CodeForces.CF2228
{
    internal class _2228B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                if (a[0]==3 || a[0]==2)
                {
                    Console.WriteLine(1);
                    continue;
                }

                var dist = Math.Abs(a[1] - a[2]);
                dist = Math.Min(dist, a[0]-dist);
                Console.WriteLine(dist + a[3]);
            }
        }
    }
}
