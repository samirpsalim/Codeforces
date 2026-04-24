namespace Leetcode.CodeForces.CP31._900
{
    internal class _1666D
    {
        static void Solve(string[] args)
        {
            var T = int.Parse(Console.ReadLine()!);
            Dictionary<char, int> counts = new Dictionary<char, int>();

            for (int i = 0; i < T; i++)
            {
                var strings = Console.ReadLine()!.Split(' ');
                var (s,t) = (strings[0],strings[1]);

                foreach (char c in t)
                {
                    if(counts.ContainsKey(c)) { counts[c]++; }
                    else { counts[c] = 1; }
                }

                string chars = "";
                var pos = t.Length - 1;

                foreach (char c in s.Reverse())
                {
                    if (counts.ContainsKey(c))
                    {
                        chars=c+chars;
                        counts[c]--;
                        if (counts[c] == 0)
                        {
                            counts.Remove(c);
                        }
                    }
                }
                Console.WriteLine(chars == t ? "YES" : "NO");

                counts.Clear();
            }
        }
    }
}
