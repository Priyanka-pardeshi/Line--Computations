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
            float Line1=Obj.Calculate(1,1,1,2);
            float Line2 = Obj.Calculate(1,2,2,2);
            
            //Equals
            Boolean Check_equality=Line1.Equals(Line2);
            if (Check_equality == true)
            {
                Console.WriteLine("Lines are Equal in length");
            }
            else
            {
                Console.WriteLine("Lines are Not Equal");
            }

           
            Console.ReadKey(); 
        }
    }
}
