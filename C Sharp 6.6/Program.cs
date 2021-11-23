using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_6._6
{
    class Program
    {
        static int ReadInteger()
        {
            bool valid = false;
            while (!valid)
            {
                Console.WriteLine("Enter a number between 0 and 100:");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num <= 100 || num >= 0)
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
                
            }
            
            
        }
        static void Main(string[] args)
        {
            int num;
            num = ReadInteger();
            if (num < 50)
                {
                    Console.WriteLine("Fail");
                }
            else if (num <= 69)
                {
                    Console.WriteLine("Pass");
                }
            else if (num <= 79)
                {
                    Console.WriteLine("Merit");
                }
            else if (num >= 80)
                {
                    Console.WriteLine("Distinction");
                }
            Console.ReadLine();
        }
    }
}
