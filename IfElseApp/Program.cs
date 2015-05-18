using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write(" Enter your  Marks : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= 0 && num1 <= 39)
            {
                Console.WriteLine("You are fail  your Grade is : F");
            }
            else if (num1 >= 40 && num1 <= 49)
            {
                Console.WriteLine("Your Grade is : B");

            }
            else if (num1 >= 50 && num1 <= 59)
            {
                Console.WriteLine("Your Grade is : B+");

            }
            else if (num1 >= 60 && num1 <= 69)
            {
                Console.WriteLine("Your Grade is : A-");

            }
            else if (num1 >= 70 && num1 <= 79)
            {
                Console.WriteLine("Your Grade is : A");

            }
            else if (num1 >= 80 && num1 <= 100)
            {
                Console.WriteLine("Your Grade is : A+");

            }
            else
            {
                Console.WriteLine("Please enter valid Marks");
            }

            
            
           Console.WriteLine("Press ENTER to EXIT");
            Console.ReadKey();
        }
        
    }
}
