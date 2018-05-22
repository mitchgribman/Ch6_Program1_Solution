using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonTasks;

namespace Ch6_Program1
{
    class Ch6_Program1 : CT
    {
        static void Main(string[] args)
        {
            Header("05/14/2018", "Ch6_Program8",
            "generate and display 100 random numbers between 1 and 1000");
            //use the random number generator from Mr. Lynch's notes
            Random numb = new Random();
            //create all the variables outside the for loop first
            int numOfEvenNum = 0;
            int minValue = 1000;
            int maxValue = 0;
            int range = 0;
            //counter controlled loop to create 100 random numbers
            for (int i = 0; i < 100; i++)
            {
                int counter = i + 1;
                int randomNum = numb.Next(0, 1001);
                int checkEven = randomNum % 2;
                if (checkEven == 0)
                {
                   numOfEvenNum++;
                }
                int z = (counter) % 4;
                Console.Write("{0} --- {1}\t\t", counter, randomNum);
                if (z == 0)
                {
                    Console.WriteLine();
                }
                minValue = Math.Min(minValue, randomNum);
                maxValue = Math.Max(maxValue, randomNum);
            }
            range = maxValue - minValue;
            Console.WriteLine("\nThe number of even numbers is {0}.",
            numOfEvenNum);
            Console.WriteLine("\nThe smallest number is {0}.", minValue);
            Console.WriteLine("\nThe largest number is {0}.", maxValue);
            Console.WriteLine("\nThe range is {0}.", range);
            Footer();
        }
            
    }
}
