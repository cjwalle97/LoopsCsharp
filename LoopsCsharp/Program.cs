using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            //for (int i = 100; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 99; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 100; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //for (int i = 100; i >= 0; i -= 2)
            //{
            //    Console.WriteLine(i);
            //}

            //2.
            //List<string> FizzandBuzz = new List<string>();
            //for(int i = 0; i <= 100; i++)
            //{
            //    if (i == 0)
            //    {
            //        Console.WriteLine(0);
            //        continue;
            //    }
            //    if (i%3 == 0 && i%5 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //        FizzandBuzz.Add("FizzBuzz");
            //        continue;
            //    }
            //    if(i%3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //        FizzandBuzz.Add("Fizz");
            //        continue;
            //    }
            //    if(i%5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //        FizzandBuzz.Add("Buzz");
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine(i);
                    

            //    }
                
            
            //}
            //Console.Read();

            //3.
            //int count = 0;
            //for (int i = 0; i <= 1000; i++)
            //{
            //    if (i % 3 == 0 || i % 5 == 0)
            //    {
            //        count += i;
            //    }
            //}

            //4.
            int i = 100;
            while (i >= 0)
            {
                i -= 1;
            }

            int k = 0;
            while (k <= 100)
            {
                k += 1;
                if (k % 3 == 0 && k%5 == 0)
                {
                    Console.WriteLine("FizzandBuzz");
                    continue;
                }
                if(k%3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                if(k%5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            int j = 0;
            int othercount = 0;
            while (j < 1000)
            {
                if (j % 3 == 0 && j % 5 == 0)
                {
                    othercount += j;
                    continue;
                }
                if (j%3 == 0)
                {
                    othercount += j;
                    continue;
                }
                if(j%5 == 0)
                {
                    othercount += j;
                }
            }
            Console.WriteLine (othercount);
        }
    }
}