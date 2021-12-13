using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning4
{
    public class Dog : Animal
    {
        public Dog(string name, int age, double weight) : base(name, age, weight)
        {
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public string ThisString()
        {
            return string.Empty;
        }

        public override string Stats()
        {
            throw new NotImplementedException();
        }
    }
    
}
