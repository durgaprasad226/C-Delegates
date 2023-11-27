using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    public delegate void AddDelegate(int a, int b);  //Same return type
    public delegate string SayDelegate(string str);  //Same parameter type
    internal class Program
    {
        public void AddNums(int a, int b)  //Same return type
        {
            Console.WriteLine(a+b);
        }

        public static string SayName(string name)  //Same parameter type
        {
            return "Hello " + name;
        }
        static void Main(string[] args)
        {
            Program p=new Program();  //Non-static method
            AddDelegate ad = new AddDelegate(p.AddNums);
            //ad(12, 26);
            ad.Invoke(12, 26);

            SayDelegate sd = new SayDelegate(SayName);  //Static method
            //string str = sd("Durga Prasad");
            string str = sd.Invoke("Durga Prasad");
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
