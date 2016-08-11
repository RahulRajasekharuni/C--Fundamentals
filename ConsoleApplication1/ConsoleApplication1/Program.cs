using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Bob = new Person("John");
            Bob.Legs = 5;
            Bob.limbs(2);
            Bob.limbs("s");
            Console.WriteLine(Bob._name);
            Console.ReadLine();
        }
    }
}
