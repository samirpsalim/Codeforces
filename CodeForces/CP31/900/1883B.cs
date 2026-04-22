namespace Leetcode.CodeForces.CP31._900
{
    internal class _1883B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            var chardict = new Dictionary<char, int>(26);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n, k) = (arr[0], arr[1]);

                var s = Console.ReadLine()!;

                foreach (char c in s)
                {
                    if (chardict.ContainsKey(c))
                    {
                        chardict[c]++;
                    }
                    else
                    {
                        chardict.Add(c, 1);
                    }
                }

                var equalizingValue = chardict.Values.Sum(v=> v%2);
                if(equalizingValue % 2 != k % 2)
                {
                    if (equalizingValue > 0) equalizingValue--;
                    else equalizingValue = 1;
                }

                if (equalizingValue>k || equalizingValue % 2 != k % 2)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    Console.WriteLine("YES");
                }

                chardict.Clear();
            }
        }
    }
}
