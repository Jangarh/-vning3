using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    internal class Hedgehog : Animal
    {
        public Hedgehog(string name, int age, double weight) : base(name, age, weight)
        {
        }

        public override string Stats()
        {
            return base.Stats() + $" It has a beautiful {Name} name.";
        }
        public override void DoSound()
        {
            Console.WriteLine("*No way to know how it sound*");
        }
    }
}
