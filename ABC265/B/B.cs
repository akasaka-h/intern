using System;
using System.Linq;

namespace ABC265
{
    class B
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Trim().Split(' ');
            var n = int.Parse(line[0]);
            var m = int.Parse(line[1]);
            var t = long.Parse(line[2]);
            line = Console.ReadLine().Trim().Split(' ');
            var a = Array.ConvertAll(line,x => long.Parse(x));

            //var xy = new List<int>().Select(_ => Console.ReadLine().Split());

            for(int i =0 ;i <m;i++)
            {
                string[] xy = Console.ReadLine().Trim().Split(' ');
                var x = int.Parse(xy[0])-1;
                var y = int.Parse(xy[1]);
                a[x] -=y;
            }

            Console.WriteLine(a.Select(x => t-=x).Count(x => x <= 0) == 0? "Yes": "No");
        }
    }
}
