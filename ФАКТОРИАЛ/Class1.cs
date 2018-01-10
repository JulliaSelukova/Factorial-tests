using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ФАКТОРИАЛ
{
    public class Class1
    {
        public ulong Factorial(ulong n)
        {
            ulong F = 1;
            for (ulong i = 1; i <= n; i++)
                F *= i;
            return F;
        }
    }
}
