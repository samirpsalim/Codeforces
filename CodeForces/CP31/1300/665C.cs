namespace Leetcode.CodeForces.CP31._1300
{
    internal class _665C
    {
        static void Solve(string[] args)
        {
            string s = Console.ReadLine()!;

            char[] ans = new char[s.Length];

            ans[0] = s[0];

            for (int i = 1; i < s.Length; i++)
            {
                if (ans[i - 1] != s[i]) ans[i] = s[i];
                else if (i == s.Length - 1) ans[i] = s[i] == 'a' ? 'b' : 'a';
                else if (ans[i-1] == s[i+1]) ans[i] = s[i] == 'a' ? 'b' : 'a';
                else ans[i]= (s[i]!='a' && s[i+1]!='a') ?'a' 
                            : (s[i] != 'b' && s[i + 1] != 'b') ? 'b'
                            :'c';
            }

            Console.WriteLine(new string(ans));
        }
    }
}
