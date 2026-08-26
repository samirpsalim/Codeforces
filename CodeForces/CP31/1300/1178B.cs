namespace Leetcode.CodeForces.CP31._1300
{
    internal record Substring(char letter, long count);

    internal class _1178B
    {
        static void Solve(string[] args)
        {
            string s = Console.ReadLine()!;

            var wcount = 0;
            var leftwcount = 0L;

            var processed = new List<Substring>();

            var curchar = s[0];
            var curlen = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i]==curchar) curlen++;
                else if (s[i] == 'v')
                {
                    if(processed.Any())
                    {
                        if (processed.Last().letter == 'o')
                        {
                            processed[processed.Count - 1] =
                                new Substring(curchar, curlen + processed.Last().count);
                        }
                        else
                        {
                            processed.Add(new Substring(curchar, curlen));
                        }
                    }
                    curchar = s[i];
                    curlen = 1;
                }
                else 
                {
                    if (curlen > 1) processed.Add(new Substring('w', curlen-1));
                    wcount += curlen - 1;
                    curchar = s[i];
                    curlen = 1;
                }
            }

            if (curchar =='v' && curlen > 1)
            {
                processed.Add(new Substring('w', curlen - 1));
                wcount += curlen - 1;
            }
            else if(processed.Any())
            {
                if (processed.Last().letter == 'o')
                {
                    processed.RemoveAt(processed.Count-1);
                }
            }

            var ans = 0L;

            foreach (var substring in processed)
            {
                if (substring.letter == 'w')
                {
                    leftwcount += substring.count;
                }
                else
                {
                    ans += substring.count * leftwcount * (wcount - leftwcount);
                }
            }

            Console.WriteLine(ans);
        }
    }
}
