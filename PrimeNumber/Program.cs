using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program // to check prime numbers in an array and print them also count them
    {
        static void Main(string[] args)
        {
           
            int store = 0;
            int v = 0;

            Console.WriteLine("Entre the size of array");
            int s = int.Parse(Console.ReadLine());

            int[] arr = new int[s];

            Console.WriteLine("Entre the Element in Array");
            int b = 0;
            while(b < s)
            {
                Console.Write("Elenemt {0} ", b + " ");
                arr[b] = int.Parse(Console.ReadLine());
                b++;
            }
            Console.WriteLine("Elements in array are");
            int c = 0;
            while (c < s)
            {
                Console.Write(arr[c]+" ");
                c++;
            }
            Console.WriteLine();
            Console.WriteLine("Prime numbers are");
           

            for (int i = 0; i < s; i++)
            {
                store = arr[i];
                int count;
                count = 0;
               

                for (int j = 1; j <= store; j++)
                {
                    if (store % j == 0)
                    {
                        count++;
                    }

                }
                if (count == 2)
                {
                    Console.Write(store + " ");
                    v++;
                }

            }
            Console.WriteLine();
            Console.WriteLine("Total prime numbers are  {0} ",v);

           
            
            Console.ReadLine();
        }
    }
}
