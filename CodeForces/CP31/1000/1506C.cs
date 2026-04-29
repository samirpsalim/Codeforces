namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1506C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                string a = Console.ReadLine()!;
                string b = Console.ReadLine()!;

                var minlen = a.Length<b.Length? a.Length : b.Length;
                var ans = a.Length+b.Length;

                for (int j = 0; j < minlen; j++)
                {
                    var flag = false;

                    for (int k=0;k< a.Length+1+j-minlen; k++)
                    {

                        for (int l = 0; l < b.Length + 1 + j - minlen; l++)
                        {
                            if(a.Substring(k,minlen-j) == b.Substring(l,minlen-j))
                            {
                                flag = true;
                                break;
                            }
                        }
                        if (flag)
                        {
                            break;
                        }
                    }
                    if(flag)
                    {
                        ans = a.Length+b.Length - 2*(minlen - j);
                        break;
                    }
                    
                }
                Console.WriteLine(ans);
            }
        }
    }
}
