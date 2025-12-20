using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF2180
{
    internal class _2180D
    {
        static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine()!);
            int prev;
            int cur;
            int start;
            int finish;

            var parsing = 0;
            var curnum = 0;
            var curpos = 0;

            for (int i = 0; i < t; ++i)
            {
                var n = int.Parse(Console.ReadLine()!);

                var x = Console.ReadLine()!;

                if (n == 1)
                {
                    Console.WriteLine(0);
                    continue;
                }

                if (n == 2)
                {
                    Console.WriteLine(1);
                    continue;
                }

                parsing = 0;

                curnum = 0;
                curpos = 0;
                cur = 0;
                prev = 0;

                while (curnum < 2)
                {
                    if (x[curpos] == ' ')
                    {
                        curnum++;
                        if(curnum ==1) prev = parsing;
                        if(curnum ==2) cur = parsing;
                        parsing = 0;
                    }
                    else
                    {
                        parsing = parsing * 10 + (x[curpos]-48);
                    }
                    curpos++;
                }

                var count = 1;
                start = cur;
                finish =2 * cur - prev;

                for (int j = 2; j < n; ++j)
                {
                    prev = cur;
                    cur = 0;
                    while(x[curpos] != ' ')
                    {
                        cur = cur * 10 + (x[curpos]-48);
                        curpos++;
                        if(curpos == x.Length) break;
                    }
                    curpos++;

                    if (cur <= start)
                    {
                        start = cur;
                        finish = 2 * cur - prev;
                        continue;
                    }
                    count++;
                    if (cur >= finish)
                    {
                        var temp = start;
                        start = 2 * cur - finish;
                        finish =2 * cur - temp;
                        continue;
                    }
                    finish = 2 * cur - start;
                    start =cur;
                }
                Console.WriteLine(count);

            }
        }
    }
}
