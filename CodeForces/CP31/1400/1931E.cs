namespace Leetcode.CodeForces.CP31._1400
{
    internal class _1931E
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                var (n,m) = (arr[0],arr[1]);

                var digcount = Console.ReadLine()!.Split(' ')
                                .OrderByDescending(si => si.Length 
                                       - si.TrimEnd('0').Length)
                                .Select((si,i)=>i%2==0?si.TrimEnd('0').Length:si.Length)
                                .Sum();

                Console.WriteLine(digcount > m ? "Sasha" : "Anna");
            }
        }
    }
}
