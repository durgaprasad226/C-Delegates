using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    public delegate string GreetDelegate2(string str);
    internal class Anonymous
    {
        static void Main(string[] args)
        {
            GreetDelegate2 gd = delegate (string name)
            {
                return "Hello " + name + " Good Morning";
            };
            string str=gd.Invoke("Viraaj");
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
