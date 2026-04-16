namespace Leetcode.CodeForces.CP31._800
{
    internal class _1890A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var elemcountdict = new Dictionary<int, int>();

                var dictlen = 0;

                foreach(var ai in a)
                {
                    if(elemcountdict.ContainsKey(ai))
                    {
                        elemcountdict[ai]++;
                    }
                    else
                    {
                        dictlen++;
                        if (dictlen > 2) break;

                        elemcountdict[ai] = 1;
                    }
                }

                if (dictlen > 2) Console.WriteLine("NO");
                else if(dictlen ==1) Console.WriteLine("YES");
                else
                {
                    var vals = elemcountdict.Values.ToArray();
                    Console.WriteLine(
                           vals[0] == vals[1] 
                        || vals[0] == vals[1]-1
                        || vals[0] == vals[1]+1
                        ? "YES" : "NO");
                }
            }
        }
    }
}
