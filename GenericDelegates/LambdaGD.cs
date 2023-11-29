using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegates
{
    /*public delegate double Delegate1(int x, float y, double z);
    public delegate void Delegate2(int x, float y, double z);
    public delegate bool Delegate3(string str);*/
    internal class LambdaGD
    {
        /*public static double AddNumbers(int x, float y, double z)
        {
            return (x + y + z);
        }
        public static void AddNumbers2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }
        public static bool CheckLength(string str)
        {
            if (str.Length > 5)
                return true;
            return false;
        }*/
        static void Main(string[] args)
        {
            Func<int, float, double, double> func = (x, y, z) =>
            {
                return (x + y + z);
            };
            double res1 = func.Invoke(12, 12.26f, 32.26);
            Console.WriteLine(res1);

            Action<int, float, double> action = (x, y, z) =>
            {
                Console.WriteLine(x + y + z);
            };
            action.Invoke(12, 12.26f, 32.26);

            Predicate<string> predicate = (str) =>
            {
                if (str.Length > 5)
                    return true;
                return false;
            };
            bool res2 = predicate.Invoke("Viraaj");
            Console.WriteLine(res2);
            Console.ReadKey();
        }
    }
}
