using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_6._2
{
    class Program
    {
        static double Volume(ref double r, ref double h)
        {
            double v = Math.PI * r * r * h;
            return v;
        }

        static double SurfaceArea(ref double r, ref double h)
        {
            double s = Math.PI * 2 * r * (r + h);
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius:");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height:");
            double h = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Volume = {0}", Volume(ref r, ref h));
            Console.WriteLine("Surface Area = {0}", SurfaceArea(ref r, ref h));
            Console.ReadLine();
        }
    }
}
