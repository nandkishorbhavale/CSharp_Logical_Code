using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Learning
{
    internal class EligibleForDriving
    {
        public static void Main(string[] args) {
            DrivingAge();
            oddEven();
        }
        public static void DrivingAge()
        {
            int age = 16;
            if (age >= 18) 
            {
                Console.WriteLine("You you drive Bro!");
            }
            else
            {
                Console.WriteLine("Sorry Bro you cannot drive!");
            }
        }
        static void oddEven()
        {
            int number = 55;
            if(number%2==0)
            {
                //bool even = true;
                Console.WriteLine(number +" is Even Number.");
            }
            else
            {
               //bool odd =false;
                Console.WriteLine(number + " is Odd Number.");
            }
           
        }
    }
}
