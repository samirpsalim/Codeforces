namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1215B
    {
        static void Solve(string[] args)
        {
            var n = int.Parse(Console.ReadLine()!);

            var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

            var negcount = 0L;
            var poscount = 0L;
            var negpref = 0;
            var pospref = 0;

            for(int i=0; i<n; i++)
            {
                if (a[i] < 0) (negpref, pospref) = (pospref + 1, negpref);
                else (negpref, pospref) = (negpref, pospref + 1);

                negcount += negpref;
                poscount += pospref;
            }

            Console.WriteLine($"{negcount} {poscount}");
        }
    }
}
