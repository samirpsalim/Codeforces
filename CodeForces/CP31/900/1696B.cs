namespace Leetcode.CodeForces.CP31._900
{
    internal class _1696B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var nonzerosegments = 0;
                var cursegmentlength = 0;

                foreach (var ai in a)
                {
                    if(ai!=0)
                    {
                        cursegmentlength++;
                    }
                    else if (cursegmentlength > 0)
                    {
                        cursegmentlength = 0;
                        nonzerosegments++;
                    }
                }

                if (cursegmentlength > 0) nonzerosegments++;

                Console.WriteLine(Math.Min(2, nonzerosegments));
            }
        }
    }
}
