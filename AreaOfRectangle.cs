using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfRectangle
{
    public class AreaOfRectangle
    {
        public static int CalculateArea(int a,  int b)
        {
            Console.Write("Enter side a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter side b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The area of the rectangle is: ", a * b);
            return AreaOfRectangle.CalculateArea(a, b);
        }
    }
}
