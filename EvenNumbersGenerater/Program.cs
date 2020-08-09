using System;
using System.Collections.Generic;

namespace EvenNumbersGenerater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hy, we are going to find all the even numbers between two numbers \n Please enter the Lower Limit");
            int firstInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the Upper Limit ");
            int lastInt = int.Parse(Console.ReadLine());

            //Invoking the Generator Method
            GenetatoMethod(firstInt, lastInt);
        }
        public static void GenetatoMethod(int lowerLimit, int upperLimit)
        {
            int counter = 0;
            var mylist = new List<int>();

            while (lowerLimit <= upperLimit)
            {
                if (counter == 0)
                {
                    if (lowerLimit % 2 == 0)
                    {
                        mylist.Add(lowerLimit);
                        counter++;
                        lowerLimit += 2;
                    }
                    else
                    {
                        lowerLimit += 1;
                    }
                }
                if (counter > 0 && lowerLimit % 2 == 0)
                {
                    mylist.Add(lowerLimit);
                    lowerLimit += 2;
                    counter++;
                }

            }
            foreach (var i in mylist)
            {
                Console.WriteLine(i);
            }
        }
    }
}
