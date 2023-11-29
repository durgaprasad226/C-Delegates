using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegates
{
    internal class AnonymousGD
    {
        static void Main(string[] args)
        {

            Func<int, float, double, double> d1 = delegate (int x, float y, double z)
            {
                return (x + y + z);
            };
            double result = d1.Invoke(12, 12.26f, 32.26);
            Console.WriteLine(result);

            Action<int, float, double> d2 = delegate (int x, float y, double z)
            {
                Console.WriteLine(x + y + z);
            };
            d2.Invoke(12, 12.26f, 32.26);

            Predicate<string> d3 = delegate (string str)
            {
                if (str.Length > 5)
                    return true;
                return false;
            };
            bool res2 = d3.Invoke("Vinishka"); 
            Console.WriteLine(res2);
            Console.ReadKey();
        }
    }
}
