using System;
using System.Linq;

namespace ABC263
{
    class C
    {
        static void Main(string[] args)
        {
            var C = new C();

            var input= C.Read_int();
            if (input == null) return ;
            var n = input[0];
            var k= input[1];

            var line = Enumerable.Range(1,k).ToArray();

            var com = C.Enumerate(line,n);
            foreach (var item in com)
            {
                string s= string.Join(",", item.Select(x=>x.ToString()).ToArray());
                Console.WriteLine(s);
            }
        }

        IEnumerable<T[]> Enumerate<T>(IEnumerable<T> items, int n)
        {
            if (n == 1)
            {
              foreach (var item in items)
                  yield return new T[] { item };
              yield break;
            }
            foreach (var item in items)
            {
                var leftside = new T[] { item };
                var unused = items.SkipWhile(e => !e.Equals(item)).Skip(1).ToList();

                foreach (var rightside in Enumerate(unused, n - 1))
                {
                  yield return leftside.Concat(rightside).ToArray();
                }
            }
        }

        //入力
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
