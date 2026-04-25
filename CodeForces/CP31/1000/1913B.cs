namespace Leetcode.CodeForces.CP31._1000
{
    internal class _1913B
    {
        static void Main(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var s = Console.ReadLine();

                var zeroes = s!.Count(c=> c=='0');
                var ones = s!.Length - zeroes;

                if(ones==0 || zeroes==0)
                {
                    Console.WriteLine(s.Length);
                    continue;
                }
                if(ones== zeroes)
                {
                    Console.WriteLine(0);
                    continue;
                }

                var searchchar = ones < zeroes ? '0' : '1';
                var searchoccurance = ones < zeroes ? ones : zeroes;

                var pos = 0;
                var occurcount = 0;

                for(pos=0;pos<s.Length;++pos)
                {
                    if(s[pos]==searchchar)
                    {
                        occurcount++;

                        if(occurcount == searchoccurance+1)
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine(s.Length - pos);

            }
        }
    }
}
