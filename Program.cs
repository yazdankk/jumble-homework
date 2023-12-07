using System;
using System.Runtime;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jumble_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number you wish to check if it is jumbled: ");
            int number;
            string input;
            while (true)
            {
                input = Console.ReadLine();

                if (int.TryParse(input, out number))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid entry, please retry.");
                }
            }
            int temp = -1;
            bool jumbled = true;
            foreach (char c in input) 
            {
                int digit = c;
                if (!(digit - 1 == temp || digit + 1 == temp) && temp != -1)
                {
                    jumbled = false;
                }
                temp = digit;
            }
            if (jumbled)
            {
                Console.WriteLine("The number is jumbled.");
            }
            else
            {
                Console.WriteLine("The number is not jumbled.");
            }
        }
    }
}