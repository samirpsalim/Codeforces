namespace Leetcode.CodeForces.CP31._800
{
    internal class _1900A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split('#', StringSplitOptions.RemoveEmptyEntries)
                          .Select(x => x.Length).ToArray();

                if(a.Length == 0)
                {
                    Console.WriteLine(0);
                    continue;
                }
                var cells = 0;
                foreach (var gap in a)
                {
                    if(gap>2)
                    {
                        cells = 2;
                        break;
                    }
                    cells += gap;
                }
                Console.WriteLine(cells);
            }
        }
    }
}
