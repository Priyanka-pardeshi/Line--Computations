using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComputation
{
    public abstract class Cal
    {
        public abstract float Call(int x1,int y1,int x2,int y2);
    }
    public class Calculate_length:Cal
    {
        public override float Call(int x1, int y1, int x2, int y2)
    {
        float length = 0;
        length = (float)Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
        Console.WriteLine("length iss=" + length);
        return length;
    }
        
    }
}
