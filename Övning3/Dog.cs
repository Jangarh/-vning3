using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    public class Dog : Animal
    {
        public string Tail { get; set; }
        public Dog(string name, int age, double weight, string tail) : base(name, age, weight)
        {
            Tail = tail;
         }

        public override void DoSound()
        {
            Console.WriteLine("*kvitter kvitter*");
        }

        public string ThisString()
        {
            return string.Empty;
        }

        public override string Stats()
        {
            return base.Stats() + $"This dog has a beautiful {Tail} I noticed";
        }
    }
    
}
