using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    //Create a delegate
    //Input parameter type should be same as method
    public delegate string GreetDelegate(string str); 
    internal class Program
    {
        //Input parameter type should be same as delegate
        public static string Greeting(string name)
        {
            return "Hello " + name + " Good Morning";
        }
        static void Main(string[] args)
        {
            //Instantiate the delegate
            //Greeting is a static method so call it directly
            GreetDelegate gd = new GreetDelegate(Greeting);
            string greet=gd.Invoke("Durga Prasad");
            Console.WriteLine(greet);
            Console.ReadKey();
        }
    }
}
