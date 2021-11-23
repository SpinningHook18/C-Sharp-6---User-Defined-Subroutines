using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_6._8
{
    class Program
    {
        static void InputData(string[] Student, int[] Results)
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();
            
        }

        static void OutputData(string[] Student, int[] Results)
        {

        }

        static void Main(string[] args)
        {
            int NumOfStudents;
            Console.Write("Enter the number of students: ");
            NumOfStudents = Convert.ToInt32(Console.ReadLine());
            string[] Name = new string[NumOfStudents];
            int[] Mark = new int[NumOfStudents];
            InputData(Name, Mark);
            //You could use DisplayChar here to separate input from output
            OutputData(Name, Mark);
            Console.ReadLine();
        }
    }
}
