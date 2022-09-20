using System;
using System.Linq;

namespace ABC264
{
    class C
    {
        static void Main(string[] args)
        {
            var C = new C();

            var input= C.Read_int();
            if (input == null) return ;
            var h1 = input[0];
            var w1= input[1];
            var arr1 = C.arr_w(h1);

            var input2= C.Read_int();
            if (input2 == null) return ;
            var h2 = input2[0];
            var w2= input2[1];
            var arr2 = C.arr_w(h2);

            var tc =C.judge(arr1,arr2,w2);
            if(tc != h2 && tc <= h2) Console.WriteLine("No");

            var arr3 = C.Trans(arr1, w1, h1);
            var arr4 = C.Trans(arr2, w2, h2);

            var tc2 = C.judge(arr3, arr4, h2);
            if(tc2 != w2 && tc2 <= w2) Console.WriteLine("No");
            if(tc2 == w2) Console.WriteLine("Yes");
        }

        //行列の転置を行う
        int[][] Trans(int[][] arr, int w, int h)
        {
            int[][] arr_trans = new int[w][];
            Enumerable.Range(0,w).ToList().ForEach( i=> {
                arr_trans[i] = new int[h];
            });
            var list_h1 = Enumerable.Range(0,h);
            var list_w1= Enumerable.Range(0,w);
            var list_hw1 = list_w1.SelectMany(i1=> list_h1.Select(i2=>(i1,i2)));
            foreach(var(i1,i2) in list_hw1)
            {
                arr_trans[i1][i2]=arr[i2][i1];
            }
            return arr_trans;
        }

        //行・列に要素を含むか判定
        int judge(int[][] arr1,int[][] arr2, int w2)
        {
            var tc = 0;
            var q = arr1.SelectMany(i1=> arr2.Select(i2=>(i1,i2)));
            foreach(var(i1,i2) in q)
            {
                var result = i1.Where(x => i2.Contains(x)).Count() == w2;
                if(result) tc += 1;
            }
            return tc;
        }

        //入力をジャグ配列(二次元配列)に
        int[][] arr_w(int h1)
        {
            var C = new C();
            int[][] arr1 = new int[h1][];
            Enumerable.Range(0,h1).ToList().ForEach( i=> {
                var a = C.Read_int();
                arr1[i] = new int[h1];
                arr1[i] = a.ToArray();
            });
            return arr1;
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
