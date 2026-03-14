namespace Leetcode.CodeForces.CF2208
{
    internal class _2208A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++) { 
                var n = int.Parse(Console.ReadLine()!);

                if(n==1)
                {
                    Console.ReadLine();
                    Console.WriteLine("NO");
                }
                else
                {
                    var a = new List<List<int>>();

                    for (int j = 0; j < n; j++)
                    {
                        a.Add(Console.ReadLine()!.Split(' ').Select(int.Parse).ToList());
                    }

                    var elemdict = new Dictionary<int, int>();
                    var possible = true;

                    foreach (var row in a)
                    {
                        foreach (var val in row)
                        {
                            if (elemdict.ContainsKey(val)) elemdict[val]++;
                            else elemdict[val] = 1;

                            if (elemdict[val] > (n - 1) * n) possible = false;
                        }
                    }

                    Console.WriteLine(possible ? "YES" : "NO");
                }

            }
        }
    }
}
