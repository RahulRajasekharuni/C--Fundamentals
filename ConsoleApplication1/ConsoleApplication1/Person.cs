using System;

namespace ConsoleApplication1
{
    public class Person : Entity
    {
        private static int arms = 2;
        private string name;

        public string _name
        {
            get { return name; }
            set { this.name = _name; }
        }


        public Person(string nm)
        {
            name = nm;
        }

        public void limbs(int x)
        {
            Console.WriteLine(Legs);
        }
        public void limbs(string x)
        {
            Console.WriteLine(arms);
        }
    }
}