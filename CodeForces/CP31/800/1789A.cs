namespace Leetcode.CodeForces.CP31._800
{
    internal class _1789A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var flag = false;

                for (int j = 0; j < n-1; j++)
                {
                    for (int k = j+1; k < n; k++)
                    {
                        if (Gcd(a[j], a[k]) <=2)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag) break;
                }

                Console.WriteLine(flag? "YES" : "NO");
            }
        }

        private static int Gcd(int a, int b)
        {
            if(a<b) return Gcd(b, a);

            if (a%b==0) return b;

            return Gcd(b, a%b);
        }
    }
}
