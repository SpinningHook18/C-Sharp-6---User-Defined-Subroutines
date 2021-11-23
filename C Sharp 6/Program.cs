using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_6
{
    class Program
    {
        static double ConvertToCelcius(ref double fahrenheit)
        {
            double celcius;
            celcius = (fahrenheit - 32) * 5 / 9;
            return celcius;
        }
        
        static void Main(string[] args)
        {
            double fahrenheit;
            Console.WriteLine("Enter temp in F:");
            fahrenheit = Convert.ToDouble(Console.ReadLine());
            fahrenheit = ConvertToCelcius(ref fahrenheit);
            Console.WriteLine("{0}", fahrenheit);
            Console.ReadLine();
        }
    }
}
