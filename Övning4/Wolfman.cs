using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning4
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, int age, double weight) : base(name, age, weight)
        {
        }

        public void Talk()
        {
            Console.WriteLine("The Wolfman is here.");
            throw new NotImplementedException();
        }
    }
}
