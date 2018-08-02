using System;
class Program
{
    static void Main(string[] args)
    {
        long[] v;

        v = new long[] { 35, 37, 46, 19, 27 };

        Console.WriteLine("??????????????????????????");

        for (int j = 0; j < v.Length - 1; j += 1)
        {

            if (v[j + 1] > v[j])
            {
                int a = (int)v[j];
                v[j] = v[j + 1];
                v[j + 1] = a;
            }

            Console.Write(v[j] + " ");
        }
        Console.WriteLine();
        for (int j = 0; j < v.Length -2; j += 1)
        {

            if (v[j + 1] > v[j])
            {
                int a = (int)v[j];
                v[j] = v[j + 1];
                v[j + 1] = a;
            }
            Console.Write(v[j] + " ");
        }
        Console.WriteLine();
        for (int j = 0; j < v.Length - 3; j += 1)
        {

            if (v[j + 1] > v[j])
            {
                int a = (int)v[j];
                v[j] = v[j + 1];
                v[j + 1] = a;
            }
            Console.Write(v[j] + " ");
        }
        Console.WriteLine();
        for (int j = 0; j < v.Length - 4; j += 1)
        {

            if (v[j + 1] > v[j])
            {
                int a = (int)v[j];
                v[j] = v[j + 1];
                v[j + 1] = a;
            }
            Console.Write(v[j] + " ");
        }
        Console.WriteLine();
        for (int j = 0; j < v.Length; j += 1)
        { Console.Write(" "+v[j]);
        }
        Console.WriteLine();
        Console.WriteLine("##########################");

    }
}



