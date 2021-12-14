using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    internal class Pelican : Bird
    {
        public bool IsMale { get; set; }
        public Pelican(string name, int age, double weight, string v, bool isMale) : base(name, age, weight)
        {
            IsMale = isMale;
        }

        public override string Stats()
        {
            return base.Stats() +$" is male? {IsMale}";
        }
    }
}
