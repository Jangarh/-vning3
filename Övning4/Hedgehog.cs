using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning4
{
    internal class Hedgehog : Animal
    {
        public Hedgehog(string name, int age, double weight) : base(name, age, weight)
        {
        }

        public override string Stats()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
