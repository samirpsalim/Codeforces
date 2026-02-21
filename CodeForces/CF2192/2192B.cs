namespace Leetcode.CodeForces.CF2192
{
    internal class _2192B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);
            for(int i = 0; i <t; ++i)
            {
                var n = int.Parse(Console.ReadLine()!);
                var s = Console.ReadLine()!;

                var oneCount = s.Count(c=>c=='1');

                if(oneCount%2==0)
                {
                    Console.WriteLine(oneCount);
                    if (oneCount != 0)
                    {
                        for (int j = 0; j < n; ++j)
                        {
                            if (s[j] == '1')
                            {
                                Console.Write(j + 1);
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
                else if(n% 2 == 0)
                {
                    Console.WriteLine(n-oneCount);
                    if (oneCount != 0)
                    {
                        for (int j = 0; j < n; ++j)
                        {
                            if (s[j] == '0')
                            {
                                Console.Write(j + 1);
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine(-1);
                }
            }
        }
    }
}
