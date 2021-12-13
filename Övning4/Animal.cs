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



        public static string DoSound()
        {
            return "";

 

          //switch (Animal) {
          //    case 'Bird':
          //        Console.WriteLine("Bird sound");
          //        break;
          //    case 'Dog':
          //        Console.WriteLine("Dog sound");
          //        break;
          //    case Hedgehog:
          //        Console.WriteLine("Hedgehog sound");
          //        break;
          //    case 'Horse':
          //        Console.WriteLine("Horse sound");
          //        break;
          //    case 'Wolf':
          //        Console.WriteLine("Wolf sound");
          //        break;
          //    case 'Worm':
          //        Console.WriteLine("Worm sound");
          //        break;
          //        default:
          //    case 'Dog':
          //        Console.WriteLine("No animail were selected.");
          //        break;
          //}
                

        }

        public abstract string ToString();

        public abstract string Stats();
       
    }

}
