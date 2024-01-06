using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeDay1;

internal class FirstDigit
{
    public static int firstDigit(int n)
    {
        while (n >= 10)
            n /= 10;

        return n;
    }
}
