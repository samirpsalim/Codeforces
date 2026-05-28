namespace Leetcode.CodeForces.CP31._1200
{
    internal class _1594C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ');

                var (n,c) = (int.Parse(arr[0]), arr[1][0]);
                string s = Console.ReadLine()!;

                if(s.All(si => si ==c))
                {
                    Console.WriteLine(0);
                    continue;
                }

                var flag = false;


                for (int j =n; j>=1; j--)
                {
                    flag = false;
                    for(int k =j-1; k<n; k+=j)
                    {
                        if (s[k]!=c)
                        {
                            flag = true;
                            break;
                        }
                    }

                    if(!flag)
                    {
                        Console.WriteLine(1);
                        Console.WriteLine(j);
                        break;
                    }
                }

                if(flag)
                {
                    Console.WriteLine(2);
                    Console.WriteLine($"{n - 1} {n}");
                }
            }
        }
    }
}
