namespace Leetcode.CodeForces.CP31._900
{
    internal class _1593B
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < t; i++)
            {
                var s = Console.ReadLine();

                int firstZeroOrFive = -1, sevenortwo = -1, j=s.Length-1;

                bool hasSeen5 =false,hasSeen0 = false;

                while(firstZeroOrFive==-1 && sevenortwo ==-1 && j>=0)
                {
                    if (hasSeen5)
                    {
                        if (s[j] == '2' || s[j] == '7')
                        {
                            sevenortwo = j;
                            break;
                        }
                    }
                    else
                    {
                        if(s[j] =='5') hasSeen5 = true;
                    }

                    if (hasSeen0)
                    {
                        if (s[j] == '0' || s[j]=='5')
                        {
                            firstZeroOrFive = j;
                            break;
                        }
                    }
                    else
                    {
                        if (s[j] == '0') hasSeen0 = true;
                    }

                    j--;
                }

                Console.WriteLine(firstZeroOrFive!=-1?s.Length-firstZeroOrFive-2 
                                  :sevenortwo!=-1? s.Length - sevenortwo - 2:-1);
            }
        }
    }
}
