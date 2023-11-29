using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegates
{
    /*public delegate double Delegate1(int x, float y, double z);
    public delegate void Delegate2(int x, float y, double z);
    public delegate bool Delegate3(string str);*/
    internal class Program
    {
        public static double AddNumbers(int x, float y, double z)
        {
            return (x + y + z);
        }
        public static void AddNumbers2(int x, float y, double z)
        {
            Console.WriteLine(x+y+z);
        }
        public static bool CheckLength(string str)
        {
            if(str.Length>5)
                return true;
             return false;
        }
        static void Main(string[] args)
        {
            //Delegate1 d1 = new Delegate1(AddNumbers);
            Func<int, float, double, double> d1 = AddNumbers; //returns a double value
            double result=d1.Invoke(12, 12.26f, 32.26);
            Console.WriteLine(result);

            //Delegate2 d2 = new Delegate2(AddNumbers2);
            Action<int, float, double> d2 = AddNumbers2; //returns nothing
            d2.Invoke(12, 12.26f, 32.26);

            //Delegate3 d3 = new Delegate3(CheckLength);
            Predicate<string> d3 = CheckLength; //Func can also be used
            bool res2 = d3.Invoke("Vinishka"); //returns a boolean value
            Console.WriteLine(res2);
            Console.ReadKey();
        }
    }
}
