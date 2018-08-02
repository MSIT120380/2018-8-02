using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 比大小
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] v;
            v = new long[] { 3, 2, 4, 9, 7 };
            Console.WriteLine("??????????????????????????");
            for (int b = 1; b < v.Length; b += 1)
            {
                for (int c = 0; c < v.Length - b; c += 1)
                {
                    if (v[c + 1] > v[c])
                    {
                        int a = (int)v[c];
                        v[c] = v[c + 1];
                        v[c + 1] = a;
                    }
                    Console.Write(v[c] + " ");
                }
                Console.WriteLine();
            }
            for (int j = 0; j < v.Length; j += 1)
            { Console.Write(v[j]); }
            Console.WriteLine("##########################");
        }
    }
}
