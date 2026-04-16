namespace Leetcode.CodeForces.CP31._800
{
    class _1873A
    {
        static void Solve(string[] args)
        {
			var t = int.Parse(Console.ReadLine()!);

			for (int i = 0; i < t; i++)
            {
                string s;
                int points = 0;
                for (int j = 0; j < 10; j++)
                {
					s = Console.ReadLine()!;

                    for (int k = 0; k < 10; k++)
                    {
                        if (s[k] == 'X')
                        {
                            points += j < k ? Math.Min(j + 1, 10 - k) : Math.Min(k + 1, 10 - j);
                        }
                    }
				}
                Console.WriteLine(points);
            }

		}
    }
}
