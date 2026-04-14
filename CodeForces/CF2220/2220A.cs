namespace Leetcode.CodeForces.CF2220
{
    class _2220A
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for(int i = 0; i < t; i++)
            {
                var n = int.Parse(Console.ReadLine()!);
                var a = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

                if(a.Distinct().Count()!=n)
                {
                    Console.WriteLine(-1);
                }
                else
                {
                    Array.Sort(a);
					Console.WriteLine(string.Join(' ',a.Reverse()));
				}
			}
        }
    }
}
