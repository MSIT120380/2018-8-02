using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random k = new Random();
            A.S(k);
            Console.WriteLine("\n");
            A.S(k);
            Console.WriteLine("\n");
            A.S(k);
            Console.WriteLine("\n");

        }
    }
    class A
    {
        public static void S(Random k)
        {
            
            double DD;
            DD= k.NextDouble();
            string[] P;
            P = new string[] { "博琛", "鈞堯", "睿鵬", "家瑄", "裕傑" };
            int Left = P.Length;

            for (int i = 0; i < P.Length; i += 1)
            {
                
                int index = (int)(DD * Left);
                Console.WriteLine(P[index]);
                {
                    string 暫存 = P[index];
                    P[index] = P[Left - 1];
                    P[Left - 1] = 暫存;
                }
                Left -= 1;
            }


        }
    }
}
