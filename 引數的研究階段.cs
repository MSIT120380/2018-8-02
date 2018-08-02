using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random k = new Random();
            double DD;
            DD = k.NextDouble(); // >= 0 && < 1 的 double
            Console.WriteLine("DD == " + DD); // 顯示 DD 的值


            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            A.S();
            A.S();
            A.S();
            A.S();
            A.S();
            A.S();
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }  
    }
    class A
    {
        public static void S()
        {
            Random k = new Random();
            double DD;
            DD = k.NextDouble(); // >= 0 && < 1 的 double
            Console.WriteLine("DD == " + DD); // 顯示 DD 的值

            string[] P; // 設一個陣列
            P = new string[] { "皮卡丘", "水箭龜", "妙蛙種子", "小火龍" };

            Console.WriteLine("????????????????????????????");
            for (int i = 0; i < P.Length; i++)
            {
                Console.Write(" " + P[i]);
            }
            Console.WriteLine();
            Console.WriteLine("###############################");

            Console.WriteLine("呼叫方法!");
            int Left = P.Length;
            {
                Left = P.Length;
                for (int i = 0; i < P.Length; i++)
                {
                    DD = k.NextDouble();
                    int index = (int)(Left * DD); // 轉型成 int
                    Console.WriteLine(index);
                    Console.Write(" " + P[index]);
                    // 對調
                    {
                        string 記下 = P[index];
                        P[index] = P[Left - 1];
                        P[Left - 1] = 記下;
                    }

                    Left -= 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$");
        }
    }
}
