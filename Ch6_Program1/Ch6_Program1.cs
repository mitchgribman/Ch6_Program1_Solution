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
            Random numb = new Random();
            int numOfEvenNum = 0;
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
            }
            Console.WriteLine("\nThe number of even numbers is {0}.",
            numOfEvenNum);
            Console.WriteLine("Hello World");
            Footer();
        }
            
    }
}
