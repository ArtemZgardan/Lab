using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Operators_advstud
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MyMax = 200;

            Random random = new Random();
            // random.Next(MaxValue) returns a 32-bit signed integer that is greater than or equal to 0 and less than MaxValue
            var b = random.Next(MyMax) + 1;
            int a = 0;
            // implement input of number and comparison result message in the while circle with  comparison condition
            

            while(a != b)
            {
                Console.WriteLine("Enter Yor guess:");
                int.TryParse(Console.ReadLine(), out a); //can't assing string to int

                if (a < b)
                {
                    Console.WriteLine("Too Low there, Bud");
                }
                else if (a > b)
                {
                    Console.WriteLine("Too far");
                }
                else 
                {
                    Console.WriteLine("Just right");
                }
                
            }
            
        }
      
    }
}
