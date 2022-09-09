using System;
using System.Linq;

namespace ABC266
{
    class C
    {
        static void Main(string[] args)
        {

            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] c = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] d = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] ad = { d[0] - a[0], d[1] - a[1] };
            int[] ba = { a[0] - b[0], a[1] - b[1] };
            int[] cb = { b[0] - c[0], b[1] - c[1] };
            int[] dc = { c[0] - d[0], c[1] - d[1] };

            float l1 = (ad[0]*(b[1]-a[1])) - (ad[1]*(b[0]-a[0]));
            float l2 = (ba[0]*(c[1]-b[1])) - (ba[1]*(c[0]-b[0]));
            float l3 = (cb[0]*(d[1]-c[1])) - (cb[1]*(d[0]-c[0]));
            float l4 = (dc[0]*(a[1]-d[1])) - (dc[1]*(a[0]-d[0]));

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
