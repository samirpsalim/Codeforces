namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1837D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                string s = Console.ReadLine()!;

                var curcolour = 1;
                var ans = new int[n];

                var dir = s[0] == '(' ? 1 : -1;
                var openbrackets = dir;
                ans[0] = curcolour;
                var totcolours = 1;

                for (int j = 1; j < n; j++)
                {
                    var cur = s[j] == '(' ? 1 : -1;

                    if (openbrackets == 0 && cur != dir)
                    {
                        curcolour=3-curcolour;
                        dir = cur;
                        totcolours = 2;
                    }
                    openbrackets += cur;
                    ans[j] = curcolour;
                }

                if(openbrackets !=0)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    Console.WriteLine(totcolours);
                    Console.WriteLine(string.Join(' ',ans));
                }
            }
        }
    }
}
