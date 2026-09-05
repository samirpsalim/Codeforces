namespace Leetcode.CodeForces.CF2259
{
    internal class _2259B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for(int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var oddcount = 0;
                var mod0count = 0;
                var mod2count = 0;

                foreach(var ai in a)
                {
                    if(ai%2==1) oddcount++;
                    else if(ai%4==0) mod0count++;
                    else mod2count++;
                }

                var ans = Math.Max(Math.Max(oddcount, mod0count), mod2count);

                Console.WriteLine(ans);
            }
        }
    }
}
