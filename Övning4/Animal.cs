using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    public abstract class Animal
    {
        string name;
        int age;
        double weight;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Animal(string name, int age, double weight)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
           
        }



        public abstract void DoSound();
      

      // public abstract string ToString();

        public virtual string Stats()
        {
            return $"This animals name is {Name}. It is {Age} years old and has {Weight} of weight.";
        }
       
    }

}
