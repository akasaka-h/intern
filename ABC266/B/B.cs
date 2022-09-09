using System;
using System.Linq;

namespace ABC266
{
    class B
    {
        static void Main(string[] args)
        {
            Int64 N = Int64.Parse(Console.ReadLine());
            Int64 k = 998244353;

            Int64 mod = N % k;

            if (mod < 0)
            {
                mod += k;
            }

            Console.WriteLine(mod);
        }
    }
}
