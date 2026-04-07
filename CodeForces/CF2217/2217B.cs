namespace Leetcode.CodeForces.CF2217
{
    internal class _2217B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!.Split(' ')[0]);

                var a = Console.ReadLine()!.Split(' ').Select(x => x == "1").ToArray();
                var p = int.Parse(Console.ReadLine()!);

                var flips = 0;
                var maxflip = 0;

                for(int j =0; j<p-1;++j)
                {
                    if (a[j] != a[j+1]) flips++;
                }
                maxflip = flips;
                flips = 0;
                for (int j = p; j < n; ++j)
                {
                    if (a[j] != a[j - 1]) flips++;
                }
                maxflip =  flips <= maxflip ? maxflip : flips;

                Console.WriteLine(maxflip % 2 == 0 ? maxflip : maxflip + 1);

            }
        }
    }
}
