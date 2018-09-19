using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Membership membership = new Membership();
            

            Console.WriteLine("Input A:");
            string inputA = Console.ReadLine();

            Console.WriteLine("Input B:");
            string inputB = Console.ReadLine();

            if (!string.IsNullOrEmpty(inputA) && !string.IsNullOrEmpty(inputB))
            {
                string membershipCheck =  membership.Check(inputA, inputB);

                string output = "The input A is: " + inputA + "\nThe input B is: " + inputB;

                if (membershipCheck != "false")
                {
                    output += "\nMembership: " + membershipCheck;
                }

                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("The input can't be empty.");
            }
        }
    }
}
