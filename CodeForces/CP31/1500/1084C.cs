namespace Leetcode.CodeForces.CP31._1500
{
    internal class _1084C
    {
        static void Solve(string[] args)
        {
            string s = Console.ReadLine()!;

            var ans = 1L;
            var cur = 1;
            var M = 1_000_000_007;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i]=='b')
                {
                    ans = (ans * cur) % M;
                    cur = 1;
                }
                else if(s[i]=='a')
                {
                    cur++;
                }
            }

            ans = (ans * cur) % M;
            Console.WriteLine(ans-1);
        }
    }
}
