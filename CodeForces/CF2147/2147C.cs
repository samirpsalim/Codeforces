using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces.CF2147
{
    internal enum FacingDirection
    {
        Left,
        Right,
        Either,
        NonExistent
    }

    internal class _2147C
    {
        private static void Solve(string[] args)
        {
            var t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {

                var n = int.Parse(Console.ReadLine());

                var s = Console.ReadLine();

                bool ans = true;

                var lastDirection = FacingDirection.NonExistent;

                for (int j = 1; j < n-1; j++)
                {
                    var faceleft = false;
                    var faceright = false;

                    if (s[j] == '0')
                    {

                        if (s.Substring(j - 1, 2) == "10")
                        {
                            if (j == 1) faceright = true;
                            else if (s.Substring(j - 2, 3) != "010") faceright = true;
                            else if (lastDirection == FacingDirection.Left)
                                faceright = true;
                            if (lastDirection == FacingDirection.Right)
                                faceleft = true;
                        }
                        if (s.Substring(j, 2) == "01")
                        {
                            if (j == n - 2) faceleft = true;
                            else if (s.Substring(j, 3) != "010")
                                faceleft = true;
                        }

                        if (faceright && faceleft)
                        {
                            ans = false;
                            break;
                        }
                        else if (faceleft) lastDirection = FacingDirection.Left;
                        else if (faceright) lastDirection = FacingDirection.Right;
                        else lastDirection = FacingDirection.Either;
                    }
                }

                if (ans) Console.WriteLine("YES");
                else Console.WriteLine("NO");
            }
        }
    }
}
