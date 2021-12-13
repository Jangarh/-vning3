using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning4
{
    public class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public Person(int age, string fName, string lName, double height, double weight)
        {
            Age = age;
            FName = fName;
            LName = lName;
            Height = height;
            Weight = weight;
        }

        public int Age 
        { get => age;
          set 
          { 
                if(value <= 0) 
                { throw new ArgumentException(nameof(age), "Age cannot be 0") ; }
                else { age = value; }
          }
        
        
        }
        
        public string FName
        {
            get => fName;
            set
            {
                //if (string.IsNullOrEmpty(value))
                //    throw new ArgumentNullException(nameof(FName));
                if(string.IsNullOrEmpty(value) || value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException(nameof(FName), "Re-enter your first name");
                }

                fName = value;     
            }
                
           
        }

       //ic void SetFName(string input)
       //
       //if (string.IsNullOrEmpty(input))
       //    throw new ArgumentException(nameof(FName), "input name");
       //fName = input;
       //

        public string LName 
        { 
            get => lName;
            set
            {
                if (string.IsNullOrEmpty(value)) 
                { 
                    throw new ArgumentException(nameof(LName), "LName cannot be empty");            
                }
                if (value.Length < 3 || value.Length > 15) 
                { 
                    throw new ArgumentException(nameof(LName), "last name must be between 3 to 15 char long"); 
                }

                lName = value;
            } 
              
                
                
        }
        public double Height 
        { 
            get => height; 
            set => height = value; 
        }
        public double Weight 
        { 
            get => weight; 
            set => weight = value; 
        }
    }

}
