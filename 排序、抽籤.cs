using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //排序
            {          
                /*
                
                long[] x;
                x = new long[] { 5, 93, 65, 60, 0, 59 };
                long a = 0, b = 0, c = 0, 現在最大, 挑戰者 = 0;

                現在最大 = x[a];
                挑戰者 = x[b];

                Console.WriteLine("大到小");


                while (a <= 5)
                {
                    現在最大 = x[a];
                    b = 0;
                    while (b <= 5)
                    {
                        挑戰者 = x[b];

                        if (挑戰者 >= 現在最大)
                        {
                            現在最大 = 挑戰者;
                            c = b;
                        }
                        if (b == 5)
                        {
                            Console.WriteLine(現在最大);
                            x[c] = 0;
                        }
                        b += 1;
                    }
                    a += 1;
                }
                if (b == 5 && 挑戰者 > 現在最大)
                {
                    現在最大 = 挑戰者;
                    Console.WriteLine(現在最大);
                    x[c] = 0;

                }
                Console.WriteLine("");*/
            }

            //排序2*
            {
                /*
                long[] x;
                x = new long[] { 5, 33, 77, 65, 57, 10, 95, 22, 0, 159 };

                long a, b, c, go_out = 0;


                for (b = 0; b < 9; b += 1)
                {
                    for (a = 0; a < 9; a += 1)
                    {

                        if (x[a + 1] > x[a])
                        {

                            go_out = x[a];
                            x[a] = x[a + 1];
                            x[a + 1] = go_out;
                        }
                    }
                }
                Console.WriteLine("");
                */
            }

            //抽籤
            {
                string[] 學生名單 = new string[] { "阿寰0", "小雞他爸爸在燒1", "古固鼓2", "歲Z3" };

                 int z = 4;
                 int 抽考 = (int)(new Random().NextDouble() * z);
                string coco = "???";

                for (z = 4; z > 0; z -= 1)
                {
                    抽考 = (int)(new Random().NextDouble() * z);
                    Console.WriteLine(學生名單[抽考]);

                    coco = 學生名單[抽考];
                    學生名單[抽考] = 學生名單[z-1];
                    學生名單[z - 1] = coco;
                }
                

                

            }




        }



    }
}


