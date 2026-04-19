using System.Threading.Channels;

namespace Leetcode.CodeForces.CP31._800
{
    internal class _1788A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var twoloc = new List<int>(n);

                for(int j=0; j<n; j++)
                {
                    if (a[j] ==2) twoloc.Add(j+1);
                }

                var ans =twoloc switch
                {
                    var list when list.Count == 0 => 1,
                    var list when list.Count % 2 == 1 => -1,
                    var list when list.Count % 2 == 0 => list[list.Count / 2 - 1],
                    _ => -1
                };

                Console.WriteLine(ans);

            }
        }
    }
}
