using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    internal class Bird : Animal
    {
        public string Color { get; set; }
        public Bird(string name, int age, double weight, string color) : base(name, age, weight)
        {
            Color = color;
        }

        public Bird(string name, int age, double weight) : base(name, age, weight)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("*kvitter kvitter*");
        }

        public override string Stats()
        {
            return base.Stats() + $" It has a beautiful {Color} color."; ;
        }

    }
}
