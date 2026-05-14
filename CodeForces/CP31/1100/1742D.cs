namespace Leetcode.CodeForces.CP31._1100
{
    internal class _1742D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse)
                        .ToArray();

                var ans = -1;

                var dict = new Dictionary<int, int>();

                for(int j =n-1; j>=0; --j)
                {
                    if(!dict.ContainsKey(a[j]))
                    {
                        dict[a[j]] = j + 1;
                        if(dict.Count == 1000)
                        {
                            break;
                        }
                    }
                }

                var relelems = dict.ToArray();

                for(int j =0; j< relelems.Length; j++)
                {
                    for(int k =j; k<relelems.Length; k++)
                    {
                        if (Gcd(relelems[j].Key, relelems[k].Key) == 1)
                        {
                            ans = Math.Max(relelems[j].Value+ relelems[k].Value, ans);
                        }
                    }
                }

                Console.WriteLine(ans);
            }
        }

        private static int Gcd(int v1, int v2)
        {
            if(v1 < v2) return Gcd(v2, v1);

            if (v1 % v2 == 0) return v2;

            return Gcd(v2, v1% v2);
        }
    }
}
