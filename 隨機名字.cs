using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m5_隨機叫出不重複的名字
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "金鋼狼", "蜘蛛人", "鋼鐵人", "奇異博士", "浩克" };
            Console.WriteLine("此程式可隨機叫出姓名(金鋼狼, 蜘蛛人, 鋼鐵人, 奇異博士, 浩克)\n\n");
            
            Random random = new Random();
            MyClass myClass = new MyClass();
            for (int k = 0; k < 5; k++)
            {
                Console.Write("隨機排序後名字: ");
                myClass.printName(name, random, k);
            }
            
            
            //while (count > 0)
            //{
            //    index_random = (int)random.Next(count); //從0到count-1間隨機取數字(小於count)
            //    Console.Write(name[index_random] + " ");
            //    string temp = name[index_random];    //變數temp暫存被random抽到的陣列值
            //    name[index_random] = name[count - 1];   //將被random抽到的陣列值換到陣列最後，因為陣列index是0~4，須count - 1
            //    name[count - 1] = temp;

            //    count = count - 1;  //將random值從原長度減1，避免重複抽
            //}
            //Console.WriteLine("\n\n");
        }
        class MyClass
        {
            public void printName(string[] name, Random random, int callcount)
            {
                int count = name.Length;
                int index_random;
                
                while (count > 0)
                {
                    index_random = (int)random.Next(count); //從0到count-1間隨機取數字(小於count)
                    if(callcount == 0)
                    Console.Write(index_random + name[index_random] + " ");
                    else
                        Console.Write(name[index_random] + " ");
                    string temp = name[index_random];    //變數temp暫存被random抽到的陣列值
                    name[index_random] = name[count - 1];   //將被random抽到的陣列值換到陣列最後，因為陣列index是0~4，須count - 1
                    name[count - 1] = temp;

                    count = count - 1;  //將random值從原長度減1，避免重複抽
                }
                Console.WriteLine("\n\n");
            }
        }
    }
}
