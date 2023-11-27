using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        public delegate void MyDelegate();
        static void Main(string[] args)
        {
            MyClass mc= new MyClass();
            MyDelegate md=new MyDelegate(mc.ValidateName);
            md();
            Console.ReadKey();
        }
    }
}
