namespace Leetcode.CodeForces.CP31._1500
{
    internal class _1516B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var totxor = a.Aggregate((agg, ai) => agg ^ ai);

                if(totxor == 0)
                {
                    Console.WriteLine("YES");
                    continue;
                }

                var curxor = 0;
                var cureqcount = 0;
                var possible = false;

                for(int j =0; j<n; j++)
                {
                    curxor = curxor ^ a[j];
                    if(curxor == totxor)
                    {
                        curxor = 0;
                        cureqcount++;
                        if(cureqcount ==2 && j<n-1)
                        {
                            possible = true;
                            break;
                        }
                    }
                }

                Console.WriteLine(possible? "YES" : "NO");
            }
        }
    }
}
