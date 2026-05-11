namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1820B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                string s = Console.ReadLine()!;

                var startseg = s.IndexOf('0');
                if(startseg == -1)
                {
                    Console.WriteLine((long)s.Length * s.Length);
                    continue;
                }

                var endseg = s.Length-1-s.LastIndexOf('0');

                var maxlen = startseg+endseg;
                var curlen = 0;
                for (int j = startseg; j < s.Length-endseg; j++)
                {
                    if (s[j] == '0')
                    {
                        curlen = 0;
                    }
                    else
                    {
                        curlen++;
                        maxlen = curlen >maxlen ? curlen : maxlen;
                    }
                }

                var mid = (maxlen + 1) / 2;
                Console.WriteLine((long)mid*(maxlen+1-mid));
            }
        }
    }
}
