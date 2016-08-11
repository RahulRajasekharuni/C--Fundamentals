using System;

namespace ConsoleApplication1
{
    public abstract class Entity
    {
        private int legs = 0;

        public int Legs
        {
            get { return legs; }
            set { this.legs = value; }
        }

        public Entity()
        {

        }

    }
}
