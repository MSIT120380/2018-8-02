using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m5_15_課外作業_6_印出來_耶誕樹_要5層_請用_靜態Method方法
{
    class Program
    {
        public static void drawHowManyWhatChar(int howMany, char whatChar)
        {
            for (int i = 0; i < howMany; i++)
            {
                Console.Write(whatChar);
            }
            Console.WriteLine();
            
        }
        static void Main(string[] args)
        {
            int Layers = 5;
            int numOfLeaf = 1;
            Char Leaf = '*'; 
            while (Layers > 0)
            {
                for (int i = 0; i < Layers; i++)
                {
                    Console.Write(" ");
                }
                Program.drawHowManyWhatChar(numOfLeaf, Leaf);
                Layers--;
                numOfLeaf += 2;
            }
            Console.WriteLine("=== 靜態方法 ===\n");
        }
    }
}
