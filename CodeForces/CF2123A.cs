using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.CodeForces
{
    internal class CF2123A
    {
        internal string BlackBoardGame(int n)
        {
            return (n % 4 == 0) ? "Bob" : "Alice";
        }
    }
}
