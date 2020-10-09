using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    abstract class Prototype
    {
        public abstract Prototype Clone();
    }

    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1()
        {
            Console.WriteLine("Prototype 1");
        }
        public override Prototype Clone()
        {
            return new ConcretePrototype1();
        }
    }

    class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2()
        {
            Console.WriteLine("Prototype 2");
        }
        public override Prototype Clone()
        {
            return new ConcretePrototype2();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Prototype ABCD = new ConcretePrototype1();
            Prototype cloneABCD = ABCD.Clone();

            Prototype EFGH = new ConcretePrototype2();
            Prototype cloneEFGH = EFGH.Clone();
        }
    }
}

