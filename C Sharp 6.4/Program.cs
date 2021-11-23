using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_6._4
{
    class Program
    {
        static int SumNatural(int n)
        {
            int t = 0;
            for (int i = 1; i <= n; i++)
            {
                t = t + i;
            }
            return t;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SumNatural(n));
            Console.ReadLine();
        }
    }
}
