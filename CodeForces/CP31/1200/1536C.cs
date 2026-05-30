namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1536C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var s = Console.ReadLine()!;

                var dict = new Dictionary<char, HashSet<int>>();

                for (int j = 0; j < n; j++)
                {
                    if (!dict.ContainsKey(s[j]))
                    {
                        dict[s[j]] = new HashSet<int>();
                    }
                    dict[s[j]].Add(j);
                }

                var flag = false;
                char curfirst = (char)('a' - 1);

                for (int j = 0; j < 26; j++)
                {
                    curfirst++;
                    if (!dict.ContainsKey(curfirst))
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag)
                {
                    Console.WriteLine(curfirst);
                    continue;
                }

                curfirst = (char)('a' - 1);
                var cursecond = (char)('a' - 1);

                for (int j = 0; j < 26; j++)
                {
                    curfirst++;
                    cursecond = (char)('a' - 1);
                    var secfound = false;
                    for (int k = 0; k < 26; k++)
                    {
                        cursecond++;
                        secfound = false;
                        foreach (int pos in dict[curfirst])
                        {
                            if (dict[cursecond].Contains(pos + 1))
                            {
                                secfound = true;
                                break;
                            }
                        }

                        if (!secfound)
                        {
                            flag = true;
                            break;
                        }
                    }

                    if (!secfound)
                    {
                        break;
                    }
                }

                if (flag)
                {
                    Console.WriteLine($"{curfirst}{cursecond}");
                    continue;
                }

                curfirst = (char)('a' - 1);
                cursecond = (char)('a' - 1);
                var curthird = (char)('a' - 1);

                for (int j = 0; j < 26; j++)
                {
                    curfirst++;
                    cursecond = (char)('a' - 1);
                    for (int k = 0; k < 26; k++)
                    {
                        cursecond++;
                        curthird = (char)('a' - 1);
                        var secpos = new List<int>();
                        foreach (int pos in dict[curfirst])
                        {
                            if (dict[cursecond].Contains(pos+1))
                            {
                                secpos.Add(pos);
                            }
                        }

                        for (int l = 0; l < 26; l++)
                        {
                            curthird++;
                            var thirdfound = false;
                            foreach (int pos in secpos)
                            {
                                if (dict[curthird].Contains(pos+2))
                                {
                                    thirdfound = true;
                                    break;
                                }
                            }
                            if (!thirdfound)
                            {
                                flag = true;
                                break;
                            }

                        }

                        if(flag)
                        {
                            break;
                        }
                    }

                    if (flag)
                    {
                        break;
                    }
                }

                Console.WriteLine($"{curfirst}{cursecond}{curthird}");

            }
        }
    }
}
