namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1673B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                string s = Console.ReadLine()!;

                HashSet<char> chars = new HashSet<char>();

                foreach (char c in s)
                {
                    chars.Add(c);
                }

                var charcounts = chars.Count;

                chars.Clear();

                var flag = false;
                
                for(int j=0; j<charcounts; j++)
                {
                    if (!chars.Add(s[j]))
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag)
                {
                    Console.WriteLine("NO");
                    continue;
                }

                for (int j=charcounts;j<s.Length; j++)
                {
                    if (s[j]!= s[j-charcounts])
                    {
                        flag = true;
                        break;
                    }
                }

                Console.WriteLine(flag? "NO" : "YES");

            }
        }
    }
}
