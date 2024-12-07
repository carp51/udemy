using System;

namespace Sample101
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i + 1;
            }

            foreach (int i in a)
            {
                Console.WriteLine(i);
            }

        }
    }
}