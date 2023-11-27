using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    public delegate void RectDelegate(double Width, double Height);
    internal class Rectangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine("Area of Rectangle : "+Width * Height);
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("Perimeter of Rectangle : "+2*(Width+Height));
        }
        public void GetSum(double Width, double Height)
        {
            Console.WriteLine("The sum is : "+ (Width+Height));
        }
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            //Non-static method, hence use class object
            RectDelegate rd = new RectDelegate(rect.GetArea);
            //RectDelegate rd = rect.GetArea; Another way to create reference
            rd += rect.GetPerimeter;
            rd+= rect.GetSum;
            rd.Invoke(12.26, 26.32);
            //rd.Invoke(26.12, 32.26);
            Console.ReadKey();
        }
    }
}
