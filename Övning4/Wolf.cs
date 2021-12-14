using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    internal class Wolf : Animal
    {
        public Wolf(string name, int age, double weight) : base(name, age, weight)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("*awoooo  awoooo*");
        }

        public override string Stats()
        {
            throw new NotImplementedException();
        }
       
    }
}
