using System;
using System.Linq;

namespace ABC264
{
    class B
    {
        static void Main(string[] args)
        {
            var B = new B();
            var input = B.Read_int();
            if (input == null) return ;
            var r = input[0];
            var c = input[1];

            int distance = Math.Max(Math.Abs(8 - r), Math.Abs(8 - c));
            if (distance % 2 == 0) Console.WriteLine("white");
            else Console.WriteLine("black");
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
