using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_6._3
{
    class Program
    {
        static void DisplayChar(char ch, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(ch);
            }
        }
        static void Main(string[] args)
        {
            DisplayChar('m', 100);
            Console.ReadLine();
        }
    }
}
