using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Learning
{
    internal class EligibleForDriving
    {
        public static void Main1(string[] args) {
            int age = 22;
            if (age >= 18)
            {
                Console.WriteLine("You can Drive!");
            }
            else
            {
                Console.WriteLine("You cannot Drive, Sorry");
            }
        }
    }
}
