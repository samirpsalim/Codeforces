namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1620B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (w,h) = (arr[0], arr[1]);

                var xarr = Console.ReadLine()!.Split(' ').Skip(1)
                           .Select(int.Parse).ToArray();
                var xdiff1 = xarr[xarr.Length - 1]-xarr[0];

                xarr = Console.ReadLine()!.Split(' ').Skip(1)
                       .Select(int.Parse).ToArray();
                var xdiff2 = xarr[xarr.Length - 1] - xarr[0];
                var xdiff = xdiff1 > xdiff2 ? xdiff1 :xdiff2;

                var yarr = Console.ReadLine()!.Split(' ').Skip(1)
                           .Select(int.Parse).ToArray();
                var ydiff1 = yarr[yarr.Length - 1] - yarr[0];

                yarr = Console.ReadLine()!.Split(' ').Skip(1)
                       .Select(int.Parse).ToArray();
                var ydiff2 = yarr[yarr.Length - 1] - yarr[0];
                var ydiff = ydiff1 > ydiff2 ? ydiff1 : ydiff2;

                Console.WriteLine(Math.Max((long)xdiff*h,(long)ydiff*w));
            }
        }
    }
}
