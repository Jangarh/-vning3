using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    internal class PersonHandler
    {
        private List<Person> persons;

        public PersonHandler()
        {
            persons = new List<Person>();
        }

        public void SetAge(Person pers, int age)
        {
            if (age > 0)
            {
                pers.Age = age;
            }
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight) 
        { 
            //return CreatePerson(age, fname, lname, height, weight); 

            var person = new Person(fname, lname);
            SetAge(person, age);
            persons.Add(person);
            return person;

        }
        public void PrintAllPersons()
        {
            foreach (var person in persons)
            {
                person.PrintPersonInfo();
            }
        }

        public void SeedPeople()
        {
            CreatePerson("Tor", "Hermansson", 32);
            CreatePerson("Beatrice", "Mansson", 22);
            CreatePerson("Per", "Berg", 36);
        }

        private void CreatePerson(string v1, string v2, int v3)
        {
            throw new NotImplementedException();
        }
    }
}
