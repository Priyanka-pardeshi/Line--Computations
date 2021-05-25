using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to calculate the length the the line");
            Calculate_length Obj = new Calculate_length();
            Obj.Calculate(1,1,1,2);
            Console.ReadKey(); 
        }
    }
}
