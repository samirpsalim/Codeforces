namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1919C
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                if(n==1)
                {
                    Console.WriteLine(0);
                    continue;
                }

                var num1 = int.MaxValue; 
                var num2 = int.MaxValue;

                var ans = 0;

                for(int j=0; j<n; j++)
                {
                    if (a[j]==num1 || a[j]==num2)
                    {
                        continue;
                    }
                    else if (a[j] < num1 && a[j] < num2)
                    {
                        if (num1 < num2) num1 = a[j];
                        else num2 = a[j];
                    }
                    else if (a[j] > num1 && a[j] > num2)
                    {
                        if (num1 < num2) num1 = a[j];
                        else num2 = a[j];
                        ans++;
                    }
                    else if (a[j] > num1 && a[j] < num2)
                    {
                        num2 = a[j];
                    }
                    else if (a[j] < num1 && a[j] > num2)
                    {
                        num1 = a[j];
                    }
                }

                Console.WriteLine(ans);
            }
        }
    }
}
