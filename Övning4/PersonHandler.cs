using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning4
{
    internal class PersonHandler
    {

        public void SetAge(Person pers, int age)
        {
            if (age > 0)
            {
                pers.Age = age;
            }
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight) 
        { 
            return CreatePerson(age, fname, lname, height, weight); 

        }

        

    }
}
