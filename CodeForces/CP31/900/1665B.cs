namespace Leetcode.CodeForces.CP31._900
{
    internal class _1665B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);

                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).Order().ToArray();

                var mostrepeating = 1;
                var currepeat = 1;

                for (int j = 1; j < n; j++)
                {
                    if (a[j] == a[j - 1]) currepeat++;
                    else currepeat = 1;

                    mostrepeating = mostrepeating > currepeat ? mostrepeating : currepeat;
                }

                var reptimes = n / mostrepeating + (n % mostrepeating == 0 ? 0 : 1);

                var pow = 0;

                while(1<<pow < reptimes)
                {
                    pow++;
                }

                Console.WriteLine(pow+n-mostrepeating);

            }
        }
    }
}
