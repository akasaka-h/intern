using System;
using System.Linq;

namespace ABC263
{
    class B
    {
        static void Main(string[] args)
        {
            var B = new B();
            var input = B.Read_int();
            if (input == null) return ;
            var n = input[0];
            var P = B.Read_int();
            int count =0;

            P.Add(n);
            var cou = P.Reverse<int>().Where(x=>x !=1).Select(x=>P[x-2]).Count();
            Console.WriteLine(cou);
        }
        List<int> Read_int()
        {
            var check = new List<bool>();
            var input = Console.ReadLine().Split(' ').Select(x => {
                var temp = 0;
                check.Add(int.TryParse(x, out temp));
                return temp;
            }).ToList();
            if (check.Any(x => x == false)) return null;
            return input;
        }
    }
}
