using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning3
{
    internal class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            Console.WriteLine("You tried to use a numeric input in a text only field.This fired an error!");
            throw new NotImplementedException();
        }
    }
}
