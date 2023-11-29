using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public delegate string MyDelegate(string name);
    internal class Program
    {
        /*public static string MyMethod(string name)
        {
            return "Hi " + name + " This is my method";
        }*/
        static void Main(string[] args)
        {
            MyDelegate md = (name)=>
            {
                return "Hi " + name + " This is my method";
            };
            string msg=md.Invoke("Vinishka");
            Console.WriteLine(msg);
            Console.ReadLine();
        }
    }
}
