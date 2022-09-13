using System;
using System.Linq;

namespace ABC266
{
    class C
    {
        int[] line(int[]a, int[]b)
        {
            int[] result = {b[0] - a[0], b[1] - a[1]};
            return result;
        }

        float outer(int[]liner, int[]a, int[]b)
        {
            float result = (liner[0]*(a[1]-b[1])) - (liner[1]*(a[0]-b[0]));
            return result;
        }
        static void Main(string[] args)
        {

            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] c = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] d = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var C = new C();
            int[] ad = C.line(a,d);
            int[] ba = C.line(b,a);
            int[] cb = C.line(c,b);
            int[] dc = C.line(d,c);

            float l1 = C.outer(ad, b, a);
            float l2 = C.outer(ba, c, b);
            float l3 = C.outer(cb, d, c);
            float l4 = C.outer(dc, a, d);

            if ((l1 < 0) && (l2 < 0) && (l3 < 0) && (l4 < 0))
            {
                Console.WriteLine("Yes");
            }else
            {
                Console.WriteLine("No");
            }
        }
    }
}
