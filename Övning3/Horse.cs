using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    internal class Horse : Animal
    {
        public string Breed { get; set; }
        public Horse(string name, int age, double weight, string breed) : base(name, age, weight)
        {
            Breed = breed;
        }

        public override string Stats()
        {
            return base.Stats() + $" The breed is: {Breed}.";
        }

        public override void DoSound()
        {
            Console.WriteLine("*Gnägg  Gnägg*");
        }
    }
}
