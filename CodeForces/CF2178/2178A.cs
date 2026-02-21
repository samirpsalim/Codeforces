namespace Leetcode.CodeForces.CF2178
{
    internal class _2178A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var s = Console.ReadLine();

                var Ycount = 0;

                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == 'Y')
                    {
                        Ycount++;
                        if(Ycount>1) break;
                    }
                }

                Console.WriteLine(Ycount > 1 ? "NO" : "YES");
            }
        }
    }
}
